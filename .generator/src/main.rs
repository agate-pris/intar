use std::{collections::HashMap, fs::File, io::BufReader, path::Path};

use anyhow::Result;
use clap::{arg, Parser};
use serde::Deserialize;
use tera::{Context, Tera};

#[derive(Debug, Parser)]
struct Args {
    /// Path to output directory
    #[arg(short, long, default_value_t = String::from("output"))]
    output: String,

    /// Path to settings file
    #[arg(long, default_value_t = String::from("settings.json"))]
    settings: String,

    /// Glob pattern for templates
    #[arg(long, default_value_t = String::from("templates/**/*.cs"))]
    templates: String,

    /// What templates to generate
    targets: Vec<String>,
}

#[derive(Debug, Deserialize)]
struct OutputFile {
    file_name: String,
    params: HashMap<String, serde_json::Value>,
}

#[derive(Debug, Deserialize)]
struct OutputDest {
    dir_path: String,
    template_name: String,
    files: Vec<OutputFile>,
}

#[derive(Debug, Deserialize)]
struct Settings {
    output_dest: Vec<OutputDest>,
}

fn load_settings<P: AsRef<Path>>(path: P) -> Result<Settings> {
    let file = File::open(path)?;
    let reader = BufReader::new(file);
    Ok(serde_json::from_reader(reader)?)
}

fn make_context(params: &HashMap<String, serde_json::Value>) -> Context {
    let mut context = Context::new();
    for (name, value) in params {
        context.insert(name, &value);
    }
    context
}

fn write_file<P: AsRef<Path>, C: AsRef<[u8]>>(path: P, contents: C) -> Result<()> {
    if let Some(parent) = path.as_ref().parent() {
        std::fs::create_dir_all(parent)?;
    }
    std::fs::write(path, contents)?;
    Ok(())
}

fn main() -> Result<()> {
    let args = Args::parse();
    let settings = load_settings(&args.settings)?;
    let tera = Tera::new(&args.templates)?;
    let path = Path::new(&args.output);
    let targets_is_empty = args.targets.is_empty();
    for output_dest in settings.output_dest {
        if !targets_is_empty && !args.targets.contains(&output_dest.template_name) {
            continue;
        }
        let path = path.join(&output_dest.dir_path);
        for file in output_dest.files {
            let path = path.join(&file.file_name);
            let context = make_context(&file.params);
            let contents = tera.render(&output_dest.template_name, &context)?;
            write_file(path, contents)?;
        }
    }
    Ok(())
}
