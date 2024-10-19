use std::{collections::HashMap, path::Path};

use anyhow::{Context, Result};
use clap::{arg, Parser};
use serde::Deserialize;
use tera::Tera;

#[derive(Debug, Parser)]
struct Args {
    /// Path to output directory
    #[arg(short, long, default_value_t = String::from("."))]
    output: String,

    /// Path to settings file
    #[arg(long, default_value_t = String::from("settings.json"))]
    settings: String,

    /// Glob pattern for templates
    #[arg(long, default_value_t = String::from("templates"))]
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
    glob: String,
    output_dest: Vec<OutputDest>,
}

fn main() -> Result<()> {
    let args = Args::parse();
    let settings = {
        let settings = std::fs::read_to_string(&args.settings)
            .with_context(|| format!("path: {}", args.settings))?;
        let mut tera = Tera::default();
        let settings = tera.render_str(&settings, &Default::default())?;
        let settings: Settings =
            serde_json::from_str(&settings).with_context(|| format!("settings: {}", settings))?;
        settings
    };
    let tera = {
        let path = &settings.glob;
        let dir = Path::new(&args.templates).join(path);
        let dir = dir.to_str().with_context(|| format!("dir: {:?}", dir))?;
        Tera::new(dir).with_context(|| format!("dir: {}", dir))?
    };
    let path = Path::new(&args.output);
    let targets_is_empty = args.targets.is_empty();
    for output_dest in settings.output_dest {
        if !targets_is_empty && !args.targets.contains(&output_dest.template_name) {
            continue;
        }
        let path = path.join(&output_dest.dir_path);
        for file in output_dest.files {
            let path = path.join(&file.file_name);
            let context = {
                let mut context = tera::Context::new();
                for (name, value) in &file.params {
                    context.insert(name, &value);
                }
                context
            };
            let contents = tera
                .render(&output_dest.template_name, &context)
                .with_context(|| format!("file: {:?}", file))?;
            if let Some(parent) = path.parent() {
                std::fs::create_dir_all(parent).with_context(|| format!("parent: {:?}", parent))?;
            }
            std::fs::write(&path, &contents)
                .with_context(|| format!("path: {:?}, contents: {}", path, contents))?;
        }
    }
    Ok(())
}
