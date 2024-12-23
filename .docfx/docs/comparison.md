# 他のライブラリとの比較

## 変換行列を右から掛けるか左から掛けるか

[`System.Numerics`](https://learn.microsoft.com/ja-jp/dotnet/api/system.numerics) は下記の形式で変換行列を作成するようになっている｡ ベクトルに対して変換行列を右から掛ける｡

$$\begin{pmatrix}
x & y & z & 1
\end{pmatrix} \begin{pmatrix}
m_{ 1\ 1 } & m_{ 1\ 2 } & m_{ 1\ 3 } & 0 \\
m_{ 2\ 1 } & m_{ 2\ 2 } & m_{ 2\ 3 } & 0 \\
m_{ 3\ 1 } & m_{ 3\ 2 } & m_{ 3\ 3 } & 0 \\
m_{ 4\ 1 } & m_{ 4\ 2 } & m_{ 4\ 3 } & 1
\end{pmatrix}$$

> ## [Remarks](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4?view=netframework-4.6.2#remarks)
>
> For matrix transformations, the [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2?view=netframework-4.6.2), [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3?view=netframework-4.6.2), and [Vector4](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector4?view=netframework-4.6.2) instances are represented as rows: a vector _v_ is transformed by a matrix _M_ with _vM_ multiplication.
>
> ―― [Matrix4x4 Struct (System.Numerics) | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4)

(`Matrix3x2` についても [同様](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix3x2) である｡ )

実際の変換時には [Vector3.Transform メソッド]([https://asdfasdfasdf](https://learn.microsoft.com/ja-jp/dotnet/api/system.numerics.vector3.transform)) を使用する。

これに対し Intar は [`System.Numerics`](https://learn.microsoft.com/ja-jp/dotnet/api/system.numerics) と異なり､ 下記の形式で変換行列を作成する｡

$$\begin{pmatrix}
m_{ 1\ 1 } & m_{ 1\ 2 } & m_{ 1\ 3 } & m_{ 1\ 4 } \\
m_{ 2\ 1 } & m_{ 2\ 2 } & m_{ 2\ 3 } & m_{ 2\ 4 } \\
m_{ 3\ 1 } & m_{ 3\ 2 } & m_{ 3\ 3 } & m_{ 3\ 4 } \\
0 & 0 & 0 & 1
\end{pmatrix} \begin{pmatrix}
x \\
y \\
z \\
1
\end{pmatrix}$$

これは UnityEngine 及び Unity.Mathematics に則ったものである。（双方ともに DirectX 標準の HLSL に由来するものと思われる）
