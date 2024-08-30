# Internal implementation of special function approximation 特殊関数の近似の内部実装

## 序文

Intar では､ [解析関数](https://ja.wikipedia.org/wiki/%E8%A7%A3%E6%9E%90%E9%96%A2%E6%95%B0) の近似に [テイラー級数](https://ja.wikipedia.org/wiki/%E3%83%86%E3%82%A4%E3%83%A9%E3%83%BC%E5%B1%95%E9%96%8B) (またはマクローリン級数) を使用する｡

このドキュメントは各関数の実行結果がバージョン毎に異なる値にならないように､ その実装の理論的背景を明らかにし､ また､ それを記録するものである｡

Intar は [ローラン級数](https://ja.wikipedia.org/wiki/%E3%83%AD%E3%83%BC%E3%83%A9%E3%83%B3%E7%B4%9A%E6%95%B0) ､ [ピュイズー級数](https://en.wikipedia.org/wiki/Puiseux_series) を使用しない｡ これは､ 除算 (特に非定数による除算)､ 平方根の計算はコストが重く､ 精度よりもパフォーマンス・再現性を重視する Intar の方向性と合わないためである｡

## 正弦 sine と余弦 cosine

以下は sin と cos のグラフ｡

![sin.svg](/images/sin.svg)

微分と積分は以下の通り｡

$$
\begin{align*}
     sin'(x)     &=  cos(x) \\
     cos'(x)     &= -sin(x) \\
\int sin (x)\ dx &= -cos(x) + C \\
\int cos (x)\ dx &=  sin(x) + C
\end{align*}
$$

sin と cos のテイラー展開は以下の通り｡

$$
\begin{align*}
\sum_{n=0}^\infty \frac{sin^{(n)}(0)}{n!}x^n &= x -
\frac{x^3}{     6} +
\frac{x^5}{   120} -
\frac{x^7}{  5040} +
\frac{x^9}{362880} - ... \\
\sum_{n=0}^\infty \frac{cos^{(n)}(0)}{n!}x^n &= 1 -
\frac{x^2}{    2} +
\frac{x^4}{   24} -
\frac{x^6}{  720} +
\frac{x^8}{40320} - ...
\end{align*}
$$

### 4 次の多項式による近似 (Abramowitz and Stegun からの引用)

> $$
> 0\le x\le\frac{\pi}{2}
> $$
>
> $$
> cos\ x=1+a_2x^2+a_4x^4+\epsilon(x)
> $$
>
> $$
> |\epsilon(x)|\le9\times10^{-4}
> $$
>
> $$
> \begin{align*}
> a_2&=-.49670&a_4&=.03705
> \end{align*}
> $$
>
> <cite id="abramowitz-and-stegun-a">Abramowitz and Stegun <sup>[\[1\]](#abramowitz-and-stegun)</sup> 4. Elementary Transcendental Functions R. Zucker 4.3. Circular Functions 4.3.98</cite>

### 3 次の多項式による近似

まず 3 次の多項式 $sin_{3}$ について考える｡

テイラー展開の結果に基づき､ 以下のように定義する｡ $k$ は定数項である｡

$$
\begin{align*}
sin_{3} \ x&=a_{3\ 1}\times x- a_{3\ 3}\times x^3\\
sin_{3}'\ x&=a_{3\ 1}        -3a_{3\ 3}\times x^2
\end{align*}
$$

この時 $sin_3\ 0=0$ は定義より自明かつ常に成り立つ｡

$sin_3\frac{\pi}{2}=1$ とすると､ $a_{3\ 1}$ と $a_{3\ 2}$ の関係が分かる｡

その上で各々の値を求めるため､ 条件をもう 1 つ追加する｡

$sin_{3}\ x$ が $x=\frac{\pi}{2}$ 付近で滑らかに変化してほしいので $sin_{3}'\frac{\pi}{2}=0$ とする｡

$$
\begin{align*}
sin_{3} \frac{\pi}{2}&=1=a_{3\ 1}\times\frac{\pi}{2}- a_{3\ 3}\times\left(\frac{\pi}{2}\right)^3\\
sin_{3}'\frac{\pi}{2}&=0=a_{3\ 1}                   -3a_{3\ 3}\times\left(\frac{\pi}{2}\right)^2\\
a_{3\ 1}&=3a_{3\ 3}\times\left(\frac{\pi}{2}\right)^2\\
1       &=3a_{3\ 3}\times\left(\frac{\pi}{2}\right)^3-a_{3\ 3}\times\left(\frac{\pi}{2}\right)^3\\
        &=2a_{3\ 3}\times\left(\frac{\pi}{2}\right)^3\\
\left(\frac{\pi}{2}\right)^{-3}&=2a_{3\ 3}\\
a_{3\ 3}&=\frac{1}{2}\left(\frac{\pi}{2}\right)^{-3}\\
a_{3\ 1}&=\frac{3}{2}\left(\frac{\pi}{2}\right)^{-1}\\
a_{3\ 2}&\approx 0.954929658551372\\
a_{3\ 3}&\approx 0.129006137732798
\end{align*}
$$

Intar では
1.0 が 2 の 15 乗に､ 直角が
1.0 ($=2^{15}$) に対応するので､ 定数項を以下のように変形する｡

$$
\begin{align*}
b_{3\ 3}&=32768\times a_{3\ 3}\left(\frac{\pi}{2}\right)^{3}&&=16384\\
b_{3\ 1}&=32768\times a_{3\ 1}\left(\frac{\pi}{2}\right)    &&=49152
\end{align*}
$$

### 4 次の多項式による近似

同様に 4 次の多項式によって近似する｡
4 次の多項式では定数項が 1 つ増えるため､
その値を確定させるために条件を追加する必要がある｡

条件 $p$ に対応する 4 次の多項式を以下のように定義する｡

$$
\begin{align*}
cos_{4\ p} x&=a_{4\ p\ 0}- a_{4\ p\ 2}x^2+ a_{4\ p\ 4}x^4\\
cos_{4\ p}'x&=           -2a_{4\ p\ 2}x  +4a_{4\ p\ 4}x^3
\end{align*}
$$

$cos\ 0=1$ であるから､ 同様に
$cos_{4\ p}0=1$ でなければならない｡ よって
$a_{4\ p\ 0}=1$ は自明｡

次に $cos\frac{\pi}{2}=0$ であるから $cos_{4\ p}\frac{\pi}{2}=0$ とする｡

$$
\begin{align*}
cos_{4\ p}\frac{\pi}{2}&=1
-a_{4\ p\ 2}\left(\frac{\pi}{2}\right)^2
+a_{4\ p\ 4}\left(\frac{\pi}{2}\right)^4=0
\end{align*}
$$

更に $a_{4\ p\ 2}$ ､ $a_{4\ p\ 4}$ を求めるため､ 以下のように定義する｡

$$
\begin{align*}
cos_{4\ 1}'\frac{\pi}{2}&=-1                 = -2a_{4\ 1\ 2}      \frac{\pi}{2}         +4a_{4\ 1\ 4}\left(\frac{\pi}{2}\right)^3\\
cos_{4\ 2}'\frac{\pi}{3}&=-\frac{\sqrt{3}}{2}= -2a_{4\ 2\ 2}      \frac{\pi}{3}         +4a_{4\ 2\ 4}\left(\frac{\pi}{3}\right)^3\\
cos_{4\ 3}'\frac{\pi}{6}&=-\frac{1       }{2}= -2a_{4\ 3\ 2}      \frac{\pi}{6}         +4a_{4\ 3\ 4}\left(\frac{\pi}{6}\right)^3\\
cos_{4\ 4} \frac{\pi}{3}&= \frac{1       }{2}=1- a_{4\ 4\ 2}\left(\frac{\pi}{3}\right)^2+ a_{4\ 4\ 4}\left(\frac{\pi}{3}\right)^4\\
cos_{4\ 5} \frac{\pi}{6}&= \frac{\sqrt{3}}{2}=1- a_{4\ 5\ 2}\left(\frac{\pi}{6}\right)^2+ a_{4\ 5\ 4}\left(\frac{\pi}{6}\right)^4\\
                       0&= \int_0^{\frac{\pi}{2}}cos_{4\ 6}x-cos\ x\ dx
\end{align*}
$$

尚､
[最小二乗法](https://ja.wikipedia.org/wiki/%E6%9C%80%E5%B0%8F%E4%BA%8C%E4%B9%97%E6%B3%95)
に基づき
[ニ乗平均平方根誤差](https://ja.wikipedia.org/wiki/%E4%BA%8C%E4%B9%97%E5%B9%B3%E5%9D%87%E5%B9%B3%E6%96%B9%E6%A0%B9%E8%AA%A4%E5%B7%AE)
(RMSD) を最小化するのが通例である｡

ここでは統計学を用いずに解くため､
上記のように条件を追加することで連立方程式として解けるようにしている｡

上記の連立方程式を解いた結果は以下の通り｡

$$
\begin{align*}
a_{4\ 1\ 2}&= \frac{8-\pi              }{\pi^2}&
a_{4\ 1\ 4}&=-\frac{4\left(\pi-4\right)}{\pi^4}\\
&\approx 0.492259582954912 &
&\approx 0.0352495783421514 \\
a_{4\ 2\ 2}&=\frac{27\sqrt{3}\pi-128            }{4\pi^2}&
a_{4\ 2\ 4}&=\frac{9\left(3\sqrt{3}\pi-16\right)}{ \pi^4}\\
&\approx 0.479192167542288 &
&\approx 0.0299535543551387 \\
a_{4\ 3\ 2}&=\frac{27\pi-16  }{14\pi^2}&
a_{4\ 3\ 4}&=\frac{18(3\pi-8)}{ 7\pi^4}\\
&\approx 0.498087713477496 &
&\approx 0.0376116306740326 \\
a_{4\ 4\ 2}&=\frac{49}{10\pi^2}&
a_{4\ 4\ 4}&=\frac{18}{ 5\pi^4}\\
&\approx 0.496473799847455 &
&\approx 0.0369575361168636 \\
a_{4\ 5\ 2}&=\frac{40-\frac{81\sqrt{3}}{4}}{\pi^2}&
a_{4\ 5\ 4}&=\frac{144-81\sqrt{3}         }{\pi^4}\\
&\approx 0.499105227174711 &
&\approx 0.0380240134427292 \\
a_{4\ 6\ 2}&=\frac{12\left(2\pi-5\right)}{\pi^3}&
a_{4\ 6\ 4}&=\frac{80\left(\pi-3\right) }{\pi^5}\\
&\approx 0.496616341424137 &
&\approx 0.0370153060419343
\end{align*}
$$

Intar の実装においては以下のように式変形を行う｡

$$
b_{4\ p\ m}=\lfloor 32768\left(\frac{\pi}{2}\right)^m a_{4\ p\ m}+0.5\rfloor
$$

$$
\begin{align*}
b_{4\ 1\ 2}&=39800&b_{4\ 1\ 4}&=7032\\
b_{4\ 2\ 2}&=38744&b_{4\ 2\ 4}&=5976\\
b_{4\ 3\ 2}&=40271&b_{4\ 3\ 4}&=7503\\
b_{4\ 4\ 2}&=40141&b_{4\ 4\ 4}&=7273\\
b_{4\ 5\ 2}&=40354&b_{4\ 5\ 4}&=7586\\
b_{4\ 6\ 2}&=40152&b_{4\ 6\ 4}&=7384
\end{align*}
$$

### 5 次の多項式による近似

条件 $p$ に対し以下のように定義する｡

$$
\begin{align*}
sin_{5\ p} x&=a_{5\ p\ 1}x- a_{5\ p\ 3}x^3+ a_{5\ p\ 5}x^5\\
sin_{5\ p}'x&=a_{5\ p\ 1} -3a_{5\ p\ 3}x^2+5a_{5\ p\ 5}x^4
\end{align*}
$$

$$
\begin{align*}
sin_{5\ p} \frac{\pi}{2}&=1&
sin_{5\ p}'\frac{\pi}{2}&=0&
sin_{5\ 1}'0            &=1
\end{align*}
$$

$$
0=\int_0^{\frac{\pi}{2}}sin_{5\ 2} (x)-sin(x)dx\\
$$

これを解くと以下の解が得られる｡

$$
\begin{align*}
a_{5\ 1\ 1}&=1&
a_{5\ 1\ 3}&=\frac{ 4(2\pi-5)}{ \pi^3}&
a_{5\ 1\ 5}&=\frac{16( \pi-3)}{ \pi^5}\\
a_{5\ 2\ 1}&=\frac{ 48-  9\pi}{2\pi^2}&
a_{5\ 2\ 3}&=\frac{192- 56\pi}{ \pi^4}&
a_{5\ 2\ 5}&=\frac{384-120\pi}{ \pi^6}
\end{align*}
$$

$$
\begin{align*}
b_{5\ 1\ m}&=\lceil  32768\ a_{5\ 1\ m}\left(\frac{\pi}{2}\right)^m \rceil\\
b_{5\ 2\ m}&=\lfloor 32768\ a_{5\ 2\ m}\left(\frac{\pi}{2}\right)^m \rfloor
\end{align*}
$$

$$
\begin{align*}
b_{5\ 1\ 1}&=51472&
b_{5\ 1\ 3}&=21024&
b_{5\ 1\ 5}&= 2320\\
b_{5\ 2\ 1}&=51436&
b_{5\ 2\ 3}&=20953&
b_{5\ 2\ 5}&= 2284
\end{align*}
$$

$c=1$ か $c=2$ かで丸め方向が異なるが､ これは丸めた時の差を小さくするため｡
$x=0$ ､ $x=\frac{\pi}{2}$ の時に精確に $1$ または $0$ にするため､
$b_{5\ c\ 1}-(b_{5\ c\ 3}-b_{5\ c\ 5})=32768$ にしなければならない｡

## 逆正接 arctangent

以下は arctan のグラフ

![atan.svg](/images/atan.svg)

微分と積分は以下の通り｡

$$
arctan'(x)=\frac{1}{x^2+1}
$$

$$
\int arctan(x)\ dx=x\ arctan(x)-\frac{log\left(x^2+1\right)}{2}
$$

以下は $arctan'(x)$ のグラフ｡

![atan_diff.svg](/images/atan_diff.svg)

以下は $\int arctan(x)\ dx$ のグラフ｡

![atan_integral.svg](/images/atan_integral.svg)

arctan のテイラー展開は以下の通り｡

$$
\sum_{n=0}^\infty \frac{arctan^{(n)}(0)}{n!}x^n = x -
\frac{x^3}{3} +
\frac{x^5}{5} -
\frac{x^7}{7} +
\frac{x^9}{9} - ...
$$

スクリプト : [atan.wmx](/gists/atan.wmx)

wip

## 逆正弦 arcsine と逆余弦 arccosine

以下は arcsin と arccos のグラフ

![asin.svg](/images/asin.svg)

微分と積分は以下の通り｡

$$
\begin{align*}
arcsin'(x)&= \frac{1}{\sqrt{1-x^2}} \\
arccos'(x)&=-\frac{1}{\sqrt{1-x^2}}
\end{align*}
$$

$$
\begin{align*}
\int arcsin(x)\ dx&=x\ arcsin(x) + \sqrt{1-x^2} + C \\
\int arccos(x)\ dx&=x\ arccos(x) - \sqrt{1-x^2} + C
\end{align*}
$$

以下は $arcsin'(x)$ と $arccos'(x)$ のグラフ｡

![asin_diff.svg](/images/asin_diff.svg)

以下は $\int arcsin(x)\ dx$ と $\int arccos(x)\ dx$ のグラフ｡

![asin_integral.svg](/images/asin_integral.svg)

arcsin と arccos のテイラー展開は以下の通り｡

$$
\begin{align*}
\sum_{n=0}^\infty \frac{arcsin^{(n)}(0)}{n!}x^n &= x +
\frac{  x^3}{   6} +
\frac{ 3x^5}{  40} +
\frac{ 5x^7}{ 112} +
\frac{35x^9}{1152} + ... \\
\sum_{n=0}^\infty \frac{arccos^{(n)}(0)}{n!}x^n &= \frac{\pi}{2} - x -
\frac{  x^3}{   6} -
\frac{ 3x^5}{  40} -
\frac{ 5x^7}{ 112} -
\frac{35x^9}{1152} - ...
\end{align*}
$$

スクリプト : [asin.wmx](/gists/asin.wxm)

wip

## Reference

1. <span id="abramowitz-and-stegun">^</span> <sup>[a](#abramowitz-and-stegun-a)</sup> Milton Abramowitz and Irene Stegun . Handbook of Mathematical Function With Formulas, Graphs, and Mathematical Tables (Abramowitz and Stegun) . United States Department of Commerce, National Bureau of Standards (NBS) , 1964

- Another fast fixed-point sine approximation | Coranac
  - http://www.coranac.com/2009/07/sines/
  - http://web.archive.org/web/20240629132053/http://www.coranac.com/2009/07/sines/
