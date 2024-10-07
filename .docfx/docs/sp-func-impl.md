# Internal implementation of special function approximation 特殊関数の近似の内部実装

## 序文

Intar では､ [解析関数](https://ja.wikipedia.org/wiki/%E8%A7%A3%E6%9E%90%E9%96%A2%E6%95%B0) の近似に [テイラー級数](https://ja.wikipedia.org/wiki/%E3%83%86%E3%82%A4%E3%83%A9%E3%83%BC%E5%B1%95%E9%96%8B) (またはマクローリン級数) を使用する｡

このドキュメントは各関数の実行結果がバージョン毎に異なる値にならないように､ その実装の理論的背景を明らかにし､ また､ それを記録するものである｡

Intar は [ローラン級数](https://ja.wikipedia.org/wiki/%E3%83%AD%E3%83%BC%E3%83%A9%E3%83%B3%E7%B4%9A%E6%95%B0) ､ [ピュイズー級数](https://en.wikipedia.org/wiki/Puiseux_series) を使用しない｡ これは､ 除算 (特に非定数による除算)､ 平方根の計算はコストが重く､ 精度よりもパフォーマンス・再現性を重視する Intar の方向性と合わないためである｡

## 正弦 sine と余弦 cosine

以下は sin と cos のグラフ｡

![sin.svg](../images/sin.svg)

テイラー展開､ 微分は以下の通り｡

> $$
> \begin{gather*}
> sin\ z =z - \frac{z^3}{3!} + \frac{z^5}{5!} - \frac{z^7}{7!} + ... & (|z| < \infty) \tag{4.3.65} \\
> cos\ z =1 - \frac{z^2}{2!} + \frac{z^4}{4!} - \frac{z^6}{6!} + ... & (|z| < \infty) \tag{4.3.66} \\
> \frac{d}{dz} sin\ z =  cos\ z \tag{4.3.105} \\
> \frac{d}{dz} cos\ z = -sin\ z \tag{4.3.106}
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.3. Circular Functions</cite>

### 2 次の多項式による近似

$cos\ z$ の近似について以下のように定義する｡

$$
\begin{gather*}
f(x) = 1 - a \times x^2 &
f(1) = 0
\end{gather*}
$$

$a = 1$ は自明｡

### 3 次の多項式による近似

$sin\ z$ の近似について以下のように定義する｡

$$
f (x) = a\ x - b\ x ^ 3
$$

$$
\begin{gather*}
f (1) = 1 & f'(1) = 0
\end{gather*}
$$

$f(1) = 1$ より $a - b = 1$ ｡ $f'(1) = 0$ より――

$$
\begin{gather*}
a - 3b = 0 & a = 3b & b = \frac{a}{3}
\end{gather*}
$$

よって――

$$
\begin{gather*}
a - \frac{a}{3} = \frac{2}{3}\ a = 1 &
a = 1.5 &
b = 0.5
\end{gather*}
$$

### 4 次の多項式による近似

以下の式に基づいて近似する｡

> $$
> 0\le x\le\frac{\pi}{2}
> $$
>
> $$
> cos\ x=1+a_2\ x^2+a_4\ x^4+\epsilon(x)
> $$
>
> $$
> |\epsilon(x)|\le9\times10^{-4}
> $$
>
> $$
> \begin{gather*}
> a_2 = -0.49670 &
> a_4 =  0.03705
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.3. Circular Functions 4.3.98</cite>

以下のように定義する｡

$$
a'_n = a_n \times \left(\frac{\pi}{2}\right)^n
$$

$$
0 \le x \le 1
$$

$$
f(x) = 1
+ a'_2\ x^2
+ a'_4\ x^4
$$

### 5 次の多項式による近似

以下の式に基づいて近似する｡

> $$
> 0\le x\le\frac{\pi}{2}
> $$
>
> $$
> \frac{sin\ x}{x} = 1 + a_2 x^2 + a_4 x^4 + \epsilon (x)
> $$
>
> $$
> |\epsilon(x)|\le2\times10^{-4}
> $$
>
> $$
> \begin{gather*}
> a_2 = -0.16605 &
> a_4 =  0.00761
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.3. Circular Functions 4.3.96</cite>

以下のように定義する｡

$$
a'_n = a_n \times \left(\frac{\pi}{2}\right)^{n+1}
$$

$$
0 \le x \le 1
$$

$$
f(x) = \frac{\pi}{2}\ x
+ a'_2              \ x^3
+ a'_4              \ x^5
$$

## 10 次の多項式による近似

以下の式に基づいて近似する｡

> $$
> 0 \le x \le \frac{\pi}{2}
> $$
>
> $$
> cos\ x = 1 +
> a_2   \ x^2    +
> a_4   \ x^4    +
> a_6   \ x^6    +
> a_8   \ x^8    +
> a_{10}\ x^{10} + \epsilon(x)
> $$
>
> $$
> | \epsilon (x) | \le 2 \times 10^{-9}
> $$
>
> $$
> \begin{align*}
> a_2    &= -0.49999\ 99963 & a_4 &= 0.04166\ 66418 \\
> a_6    &= -0.00138\ 88397 & a_8 &= 0.00002\ 47609 \\
> a_{10} &= -0.00000\ 02605
> \end{align*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.3. Circular Functions 4.3.99</cite>

以下のように定義する｡

$$
a'_n = a_n \times \left(\frac{\pi}{2}\right)^n
$$

$$
0 \le x \le 1
$$

$$
f(x) = 1
+ a'_{ 2}\ x^{ 2}
+ a'_{ 4}\ x^{ 4}
+ a'_{ 6}\ x^{ 6}
+ a'_{ 8}\ x^{ 8}
+ a'_{10}\ x^{10}
$$

## 11 次の多項式による近似

以下の式に基づいて近似する｡

> $$
> 0 \le x \le \frac{\pi}{2}
> $$
>
> $$
> \frac{sin\ x}{x} = 1 +
> a_2   \ x^2    +
> a_4   \ x^4    +
> a_6   \ x^6    +
> a_8   \ x^8    +
> a_{10}\ x^{10} + \epsilon(x)
> $$
>
> $$
> | \epsilon (x) | \le 2 \times 10^{-9}
> $$
>
> $$
> \begin{align*}
> a_2    &= -0.16666\ 66664 & a_4 &= 0.00833\ 33315 \\
> a_6    &= -0.00019\ 84090 & a_8 &= 0.00000\ 27526 \\
> a_{10} &= -0.00000\ 00239
> \end{align*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.3. Circular Functions 4.3.97</cite>

以下のように定義する｡

$$
a'_n = a_n \times \left(\frac{\pi}{2}\right)^{n+1}
$$

$$
0 \le x \le 1
$$

$$
f(x) = \frac{\pi}{2}\ x
+ a'_{ 2}           \ x^{ 3}
+ a'_{ 4}           \ x^{ 5}
+ a'_{ 6}           \ x^{ 7}
+ a'_{ 8}           \ x^{ 9}
+ a'_{10}           \ x^{11}
$$

## 逆正接 arctangent

以下は arctan のグラフ

![atan.svg](../images/atan.svg)

テイラー展開､ 微分は以下の通り｡

> $$
> \begin{gather*}
> arctan\ z = z
> - \frac{z^3}{3}
> + \frac{z^5}{5}
> - \frac{z^7}{7} + ... &
> (|z| \le 1\ and\ z^2 \neq -1) \tag{4.4.42} \\
> \frac{d}{dz} arctan\ z = \frac{1}{1+z^2} \tag{4.4.54}
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.4. Inverse Circular Functions</cite>

スクリプト : [atan.wxm](../gists/atan.wxm)

### 2 次の多項式による近似

以下の式に基づいて近似する｡

> Using an extensive computer search,
> the optimum $\alpha \approx 0.273$
> and the following approximation for the $arctan(x)$
> with a maximum absolute error
> of $0.0038$ rad ($0.22 \textdegree$) are obtained:
>
> $$
> -1 \le x \le 1
> $$
>
> $$
> arctan(x) \approx
> \frac{\pi}{4} \ x + 0.273x (1 - |x|) \tag{7}
> $$
>
> <cite>Efficient approximations for the arctangent function [^efficient-atan-approx-func]</cite>

以下のように定義する｡

$$
0 \le x \le 1
$$

$$
\begin{align*}
f(x)
&= \frac{1}{4}x + \frac{0.273}{\pi}x\ (1 - x) \\
&= x \left( \frac{1}{4} + \frac{0.273}{\pi} \left( 1 - x \right) \right)
\end{align*}
$$

### 3 次の多項式による近似

以下の式に基づいて近似する｡

> ... Using the minimax criteria,
> the following polynomial with a maximum absolute error
> of $0.0015$ rad ($0.086 \textdegree$) is identified as the optimal approximation to $arctan(x)$
>
> $$
> -1 \le x \le 1
> $$
>
> $$
> arctan(x) \approx
> \frac{\pi}{4} \ x - x (|x| - 1) \times (0.2447 + 0.0663 |x|) \tag{9}
> $$
>
> <cite>Efficient approximations for the arctangent function [^efficient-atan-approx-func]</cite>

以下のように定義する｡

$$
0 \le x \le 1
$$

$$
\begin{align*}
f(x)
&= \frac{1}{4} \ x - x \ (x - 1) \times \left( \frac{0.2447}{\pi} + \frac{0.0663}{\pi} x \right) \\
&= x \left( \frac{1}{4} - (x - 1) \times \left( \frac{0.2447}{\pi} + \frac{0.0663}{\pi} x \right) \right)
\end{align*}
$$

## 9 次の多項式による近似

以下の式に基づいて近似する｡

> $$
> -1 \le x \le 1
> $$
>
> $$
> arctan\ x = a_1 x + a_3 x^3 + a_5 x^5 + a_7 x^7 + a_9 x^9 + \epsilon (x)
> $$
>
> $$
> | \epsilon (x) | \le 10^{-5}
> $$
>
> $$
> \begin{gather*}
> a_1 = 0.99986\ 60 & a_3 = -0.33029\ 95 \\
> a_5 = 0.18014\ 10 & a_7 = -0.08513\ 30 \\
> a_9 = 0.02083\ 51
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.4. Inverse Circular Functions 4.4.47</cite>

以下のように定義する｡

$$
0 \le x \le 1
$$

$$
a'_n = \frac{a_n}{\pi}
$$

$$
\begin{align*}
f(x) &
= a'_1\ x
+ a'_3\ x^3
+ a'_5\ x^5
+ a'_7\ x^7
+ a'_9\ x^9 \\
&=x
\left( a'_1 -        x^2
\left(-a'_3 -        x^2
\left( a'_5 -        x^2
\left(-a'_7 - a'_9 \ x^2
\right)
\right)
\right)
\right)
\end{align*}
$$

## 逆正弦 arcsine と逆余弦 arccosine

以下は arcsin と arccos のグラフ

![asin.svg](../images/asin.svg)

以下は $arcsin'(x)$ と $arccos'(x)$ のグラフ｡

![asin_diff.svg](../images/asin_diff.svg)

テイラー展開と微分は以下の通り｡

> $$
> \begin{gather*}
> arcsin\ z
> =                         z
> + \frac{                  z^3}{2                 \cdot 3}
> + \frac{1 \cdot 3         z^5}{2 \cdot 4         \cdot 5}
> + \frac{1 \cdot 3 \cdot 5 z^7}{2 \cdot 4 \cdot 6 \cdot 7} \cdots & (|z| < 1) \tag{4.4.40} \\
> \frac{d}{dz} arcsin\ z = \left(1 - z^2\right)^{-\frac{1}{2}} \tag{4.4.52} \\
> \frac{d}{dz} arccos\ z =-\left(1 - z^2\right)^{-\frac{1}{2}} \tag{4.4.52} \\
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.4. Inverse Circular Functions</cite>

スクリプト : [asin.wmx](../gists/asin.wxm)

### 3 次の多項式と平方根による近似

以下の式に基づいて近似する｡

> $$
> arcsin\ x = \frac{\pi}{2} - \left(1 - x\right)^\frac{1}{2} \left(
> a_0      +
> a_1\ x   +
> a_2\ x^2 +
> a_3\ x^3 \right) + \epsilon(x)
> $$
>
> $$
> |\epsilon(x)| \le 5 \times 10^{-5}
> $$
>
> $$
> \begin{gather*}
> a_0 = 1.57072\ 88 & a_1 = -0.21211\ 44 \\
> a_2 = 0.07426\ 10 & a_3 = -0.01872\ 93
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.4. Inverse Circular Functions 4.4.45</cite>

以下のように定義する｡

$$
0 \le x \le 1
$$

$$
a'_n = \frac{2}{\pi} \times a_n
$$

$$
f(x) = 1 - (1 - x)^\frac{1}{2} \left( a'_0 + a'_1\ x + a'_2\ x^2 + a'_3\ x^3 \right)
$$

### 7 次の多項式と平方根による近似

以下の式に基づいて近似する｡

> $$
> \begin{align*}
> arcsin\ x = \frac{\pi}{2} - \left(1 - x\right)^\frac{1}{2}
> \left(   a_0
>        + a_1\ x
>        + a_2\ x^2
>        + a_3\ x^3 \right. \\
> \left. + a_4\ x^4
>        + a_5\ x^5
>        + a_6\ x^6
>        + a_7\ x^7 \right) + \epsilon(x)
> \end{align*}
> $$
>
> $$
> |\epsilon(x)| \le 2 \times 10^{-8}
> $$
>
> $$
> \begin{gather*}
> a_0 = 1.57079\ 63050 & a_1 = -0.21459\ 88016 \\
> a_2 = 0.08897\ 89874 & a_3 = -0.05017\ 43046 \\
> a_4 = 0.03089\ 18810 & a_5 = -0.01708\ 81256 \\
> a_6 = 0.00667\ 00901 & a_7 - -0.00126\ 24911
> \end{gather*}
> $$
>
> <cite>Abramowitz and Stegun [^abramowitz-and-stegun] 4. Elementary Transcendental Functions R. Zucker 4.4. Inverse Circular Functions 4.4.46</cite>

以下のように定義する｡

$$
0 \le x \le 1
$$

$$
a'_n = \frac{2}{\pi} \times a_n
$$

$$
\begin{align*}
f(x) = 1 - (1 - x)^\frac{1}{2}
\left(   a'_0
       + a'_1\ x
       + a'_2\ x^2
       + a'_3\ x^3 \right. \\
\left. + a'_4\ x^4
       + a'_5\ x^5
       + a'_6\ x^6
       + a'_7\ x^7 \right)
\end{align*}
$$

## 参考文献

- Another fast fixed-point sine approximation | Coranac
  - http://www.coranac.com/2009/07/sines/
  - http://web.archive.org/web/20240629132053/http://www.coranac.com/2009/07/sines/

[^abramowitz-and-stegun]: Milton Abramowitz and Irene Stegun . Handbook of Mathematical Function With Formulas, Graphs, and Mathematical Tables (Abramowitz and Stegun) . United States Department of Commerce, National Bureau of Standards (NBS) , 1964

[^efficient-atan-approx-func]: Efficient approximations for the arctangent function, Rajan, S. Sichun Wang Inkol, R. Joyal, A., May 2006

    - https://ieeexplore.ieee.org/document/1628884/
    - https://www-labs.iro.umontreal.ca/~mignotte/IFT2425/Documents/EfficientApproximationArctgFunction.pdf
