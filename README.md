# Intar

ドキュメントは https://agate-pris.github.io/intar/ を参照｡

## 変換行列を右から掛けるか左から掛けるか

[`System.Numerics`](https://learn.microsoft.com/ja-jp/dotnet/api/system.numerics) は下記の形式で変換行列を作成するようになっている｡ ベクトルに対して変換行列を右から掛ける｡

$$\begin{pmatrix}
x_{ 0 } & y_{ 0 } & z_{ 0 } & 1
\end{pmatrix} \begin{pmatrix}
x_{ 1 } & x_{ 2 } & x_{ 3 } & 0 \\
y_{ 1 } & y_{ 2 } & y_{ 3 } & 0 \\
z_{ 1 } & z_{ 2 } & z_{ 3 } & 0 \\
w_{ 1 } & w_{ 2 } & w_{ 3 } & 1
\end{pmatrix}$$

> ## [Remarks](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4?view=netframework-4.6.2#remarks)
>
> For matrix transformations, the [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2?view=netframework-4.6.2), [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3?view=netframework-4.6.2), and [Vector4](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector4?view=netframework-4.6.2) instances are represented as rows: a vector _v_ is transformed by a matrix _M_ with _vM_ multiplication.
>
> ―― [Matrix4x4 Struct (System.Numerics) | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4)

(`Matrix3x2` についても [同様](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix3x2) である｡ )

これに対し Intar は [`System.Numerics`](https://learn.microsoft.com/ja-jp/dotnet/api/system.numerics) と異なり､ 下記の形式で変換行列を作成する｡

$$\begin{pmatrix}
x_{ 1 } & y_{ 1 } & z_{ 1 } & w_{ 1 } \\
x_{ 2 } & y_{ 2 } & z_{ 2 } & w_{ 2 } \\
x_{ 3 } & y_{ 3 } & z_{ 3 } & w_{ 3 } \\
0 & 0 & 0 & 1
\end{pmatrix} \begin{pmatrix}
x_{ 0 } \\
y_{ 0 } \\
z_{ 0 } \\
1
\end{pmatrix}$$

これは､ 同じ親を持つトランスフォームが存在する時､ 上記の形式であれば､ 通常の乗算演算子による乗算と同じように左優先で結合した際に子の座標に対して同じ変換行列が掛けられるためである｡

Intar は固定小数点数を取り扱うため､ その演算誤差は浮動小数点数の演算よりも大きくなりやすく､ 演算の順序はより重要である｡

## Development

Install .net 4.6.2 from Visual Studio Installer.

The following extensions are required.

- NUnit 3 Test Adapter

NugGet Package Manager is required. See below.

https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio#package-sources
