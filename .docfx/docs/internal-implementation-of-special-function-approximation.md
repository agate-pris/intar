# Internal implementation of special function approximation 特殊関数の近似の内部実装

## 正弦 sine と余弦 cosine

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

### sin と cos のテイラー展開

$sin$ と $cos$ はテイラー級数

$$
\sum_{n=0}^\infty \frac{f^{(n)}(a)}{n!}(x-a)^n
$$

により､ 以下の式で近似できる｡

$$
\begin{align*}
\sum_{n=0}^\infty\frac{sin^{(n)}(a)}{n!}(x-a)^n
&=\frac{sin(a)}{0!}(x-a)^0&&+\frac{cos(a)}{1!}(x-a)^1\\
&-\frac{sin(a)}{2!}(x-a)^2&&-\frac{cos(a)}{3!}(x-a)^3\\
&+\frac{sin(a)}{4!}(x-a)^4&&+\frac{cos(a)}{5!}(x-a)^5...
\end{align*}
$$

$$
\begin{align*}
\sum_{n=0}^\infty\frac{cos^{(n)}(a)}{n!}(x-a)^n
&=\frac{cos(a)}{0!}(x-a)^0&&-\frac{sin(a)}{2!}(x-a)^1\\
&-\frac{cos(a)}{2!}(x-a)^2&&+\frac{sin(a)}{3!}(x-a)^3\\
&+\frac{cos(a)}{4!}(x-a)^4&&-\frac{sin(a)}{5!}(x-a)^5...
\end{align*}
$$

この時 $sin\ 0=0$ ､ $cos\ 0=1$ であるから､ $a=0$ の時

$$
\begin{align*}
\sum_{n=0}^\infty\frac{sin^{(n)}(0)}{n!}(x-0)^n
&=x-\frac{x^3}{3!}+\frac{x^5}{5!}...\\
\sum_{n=0}^\infty\frac{cos^{(n)}(0)}{n!}(x-0)^n
&=1-\frac{x^2}{2!}+\frac{x^4}{4!}...
\end{align*}
$$

上記より
$sin$ の近似には偶数項が､
$cos$ の近似には奇数項が､ それぞれ不要であることが分かる｡

$sin\ x=cos(x+\frac{\pi}{2})$ であるから､
オフセットを足すことを前提に各々のテイラー展開の結果を奇数次の多項式による近似と偶数次の多項式による近似とみなすことができる｡

しかし､ 単純にテイラー展開の結果の一部を切り出して $n$ 次の多項式による近似として用いる場合､
$sin\frac{\pi}{2}=1$ ､ $cos\frac{\pi}{2}=0$ を満たさず都合が悪い｡

よって､ 多項式近似では係数を調整することでこれらを満たすように調整する｡

### 3 次の多項式による近似

まず 3 次の多項式 $sin_{3}$ について考える｡

テイラー展開の結果に基づき､ 以下のように定義する｡ $k$ は定数項である｡

$$
\begin{align*}
sin_{3} \ x&=k_{3\ 1}\times x- k_{3\ 3}\times x^3\\
sin_{3}'\ x&=k_{3\ 1}        -3k_{3\ 3}\times x^2
\end{align*}
$$

この時 $sin_3\ 0=0$ は定義より自明かつ常に成り立つ｡

$sin_3\frac{\pi}{2}=1$ とすると､ $k_{3\ 1}$ と $k_{3\ 2}$ の関係が分かる｡

その上で各々の値を求めるため､ 条件をもう 1 つ追加する｡

$sin_{3}\ x$ が $x=\frac{\pi}{2}$ 付近で滑らかに変化してほしいので $sin_{3}'\frac{\pi}{2}=0$ とする｡

$$
\begin{align*}
sin_{3} \frac{\pi}{2}&=1=k_{3\ 1}\times\frac{\pi}{2}- k_{3\ 3}\times\left(\frac{\pi}{2}\right)^3\\
sin_{3}'\frac{\pi}{2}&=0=k_{3\ 1}                   -3k_{3\ 3}\times\left(\frac{\pi}{2}\right)^2\\
k_{3\ 1}&=3k_{3\ 3}\times\left(\frac{\pi}{2}\right)^2\\
1       &=3k_{3\ 3}\times\left(\frac{\pi}{2}\right)^3-k_{3\ 3}\times\left(\frac{\pi}{2}\right)^3\\
        &=2k_{3\ 3}\times\left(\frac{\pi}{2}\right)^3\\
\left(\frac{\pi}{2}\right)^{-3}&=2k_{3\ 3}\\
k_{3\ 3}&=\frac{1}{2}\left(\frac{\pi}{2}\right)^{-3}\\
k_{3\ 1}&=\frac{3}{2}\left(\frac{\pi}{2}\right)^{-1}\\
k_{3\ 2}&\approx 0.954929658551372\\
k_{3\ 3}&\approx 0.129006137732798
\end{align*}
$$

Intar では
1.0 が 2 の 15 乗に､ 直角が
1.0 ($=2^{15}$) に対応するので､ 定数項を以下のように変形する｡

$$
\begin{align*}
ik_{3\ 3}&=32768\times k_{3\ 3}\left(\frac{\pi}{2}\right)^{3}&&=16384\\
ik_{3\ 1}&=32768\times k_{3\ 1}\left(\frac{\pi}{2}\right)    &&=49152\\
\end{align*}
$$

### 4 次の多項式による近似

同様に 4 次の多項式によって近似する｡
4 次の多項式では定数項が 1 つ増えるため､
その値を確定させるために条件を追加する必要がある｡

条件 $c$ に対応する 4 次の多項式を以下のように定義する｡

$$
\begin{align*}
cos_{4\ c} x&=k_{4\ c\ 0}- k_{4\ c\ 2}x^2+ k_{4\ c\ 4}x^4\\
cos_{4\ c}'x&=           -2k_{4\ c\ 2}x  +4k_{4\ c\ 4}x^3
\end{align*}
$$

$cos\ 0=1$ であるから､
同様に $cos_{4\ c}\ 0=1$ でなければならない｡
よって $k_{4\ c\ 0}=1$ は自明｡

次に $cos\frac{\pi}{2}=0$ であるから $cos_{4\ c}\frac{\pi}{2}=0$ とする｡

$$
\begin{align*}
cos_{4\ c}\frac{\pi}{2}&=1
-k_{4\ c\ 2}\left(\frac{\pi}{2}\right)^2
+k_{4\ c\ 4}\left(\frac{\pi}{2}\right)^4=0
\end{align*}
$$

更に $k_{4\ c\ 2}$ ､ $k_{4\ c\ 4}$ を求めるため､ 以下のように定義する｡

$$
\begin{align*}
cos_{4\ 1}'\frac{\pi}{2}&=-1                 = -2k_{4\ 1\ 2}      \frac{\pi}{2}         +4k_{4\ 1\ 4}\left(\frac{\pi}{2}\right)^3\\
cos_{4\ 2}'\frac{\pi}{3}&=-\frac{\sqrt{3}}{2}= -2k_{4\ 2\ 2}      \frac{\pi}{3}         +4k_{4\ 2\ 4}\left(\frac{\pi}{3}\right)^3\\
cos_{4\ 3}'\frac{\pi}{6}&=-\frac{1       }{2}= -2k_{4\ 3\ 2}      \frac{\pi}{6}         +4k_{4\ 3\ 4}\left(\frac{\pi}{6}\right)^3\\
cos_{4\ 4} \frac{\pi}{3}&= \frac{1       }{2}=1- k_{4\ 4\ 2}\left(\frac{\pi}{3}\right)^2+ k_{4\ 4\ 4}\left(\frac{\pi}{3}\right)^4\\
cos_{4\ 5} \frac{\pi}{6}&= \frac{\sqrt{3}}{2}=1- k_{4\ 5\ 2}\left(\frac{\pi}{6}\right)^2+ k_{4\ 5\ 4}\left(\frac{\pi}{6}\right)^4\\
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
k_{4\ 1\ 2}&= \frac{8-\pi              }{\pi^2}&
k_{4\ 1\ 4}&=-\frac{4\left(\pi-4\right)}{\pi^4}\\
&\approx 0.492259582954912 &
&\approx 0.0352495783421514 \\
k_{4\ 2\ 2}&=\frac{27\sqrt{3}\pi-128            }{4\pi^2}&
k_{4\ 2\ 4}&=\frac{9\left(3\sqrt{3}\pi-16\right)}{ \pi^4}\\
&\approx 0.479192167542288 &
&\approx 0.0299535543551387 \\
k_{4\ 3\ 2}&=\frac{27\pi-16  }{14\pi^2}&
k_{4\ 3\ 4}&=\frac{18(3\pi-8)}{ 7\pi^4}\\
&\approx 0.498087713477496 &
&\approx 0.0376116306740326 \\
k_{4\ 4\ 2}&=\frac{49}{10\pi^2}&
k_{4\ 4\ 4}&=\frac{18}{ 5\pi^4}\\
&\approx 0.496473799847455 &
&\approx 0.0369575361168636 \\
k_{4\ 5\ 2}&=\frac{40-\frac{81\sqrt{3}}{4}}{\pi^2}&
k_{4\ 5\ 4}&=\frac{144-81\sqrt{3}         }{\pi^4}\\
&\approx 0.499105227174711 &
&\approx 0.0380240134427292 \\
k_{4\ 6\ 2}&=\frac{12\left(2\pi-5\right)}{\pi^3}&
k_{4\ 6\ 4}&=\frac{80\left(\pi-3\right) }{\pi^5}\\
&\approx 0.496616341424137 &
&\approx 0.0370153060419343
\end{align*}
$$

Intar の実装においては以下のように式変形を行う｡

$$
\begin{align*}
ik_{4\ 1\ 2}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 1\ 2}+0.5\rfloor&
ik_{4\ 1\ 4}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 1\ 4}+0.5\rfloor\\
&=\lfloor 8192(8-\pi)+0.5\rfloor&
&=\lfloor 8192(4-\pi)+0.5\rfloor\\
&=39800&
&= 7032\\
ik_{4\ 2\ 2}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 2\ 2}+0.5\rfloor&
ik_{4\ 2\ 4}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 2\ 4}+0.5\rfloor\\
&=\lfloor 2048\left(-128+27\sqrt{3}\pi\right)+0.5\rfloor&
&=\lfloor 1832\left(- 16+ 3\sqrt{3}\pi\right)+0.5\rfloor\\
&=38744&
&= 5976\\
ik_{4\ 3\ 2}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 3\ 2}+0.5\rfloor&
ik_{4\ 3\ 4}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 3\ 4}+0.5\rfloor\\
&=\lfloor\frac{ 4096}{7}(-16-27\pi)+0.5\rfloor&
&=\lfloor\frac{36864}{7}(- 8+ 3\pi)+0.5\rfloor\\
&=40271&
&= 7503\\
ik_{4\ 4\ 2}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 4\ 2}+0.5\rfloor&
ik_{4\ 4\ 4}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 4\ 4}+0.5\rfloor\\
&=40141&
&= 7273\\
ik_{4\ 5\ 2}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 5\ 2}+0.5\rfloor&
ik_{4\ 5\ 4}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 5\ 4}+0.5\rfloor\\
&=\lfloor 8192\left(40-\frac{81\sqrt{3}}{4}\right)&
&=\lfloor 2048\left(144-81\sqrt{3}\right)\\
&=40354&
&= 7586\\
ik_{4\ 6\ 2}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 6\ 2}+0.5\rfloor&
ik_{4\ 6\ 4}&=\lfloor 32768\left(\frac{\pi}{2}\right)^2k_{4\ 6\ 4}+0.5\rfloor\\
&=\lfloor\frac{ 98304(-5+2\pi)}{\pi}+0.5\rfloor&
&=\lfloor\frac{163840(-3+ \pi)}{\pi}+0.5\rfloor\\
&=40152&
&= 7384
\end{align*}
$$

### 5 次の多項式による近似

条件 $c$ に対し以下のように定義する｡

$$
\begin{align*}
sin_{5\ c} x&=k_{5\ c\ 1}x- k_{5\ c\ 3}x^3+ k_{5\ c\ 5}x^5\\
sin_{5\ c}'x&=k_{5\ c\ 1} -3k_{5\ c\ 3}x^2+5k_{5\ c\ 5}x^4
\end{align*}
$$

$$
\begin{align*}
sin_{5\ c} \frac{\pi}{2}&=1&
sin_{5\ c}'\frac{\pi}{2}&=0&
sin_{5\ 1}'0            &=1
\end{align*}
$$

$$
0=\int_0^{\frac{\pi}{2}}sin_{5\ 2} (x)-sin(x)dx\\
$$

これを解くと以下の解が得られる｡

$$
\begin{align*}
k_{5\ 1\ 1}&=1&
k_{5\ 1\ 3}&=\frac{ 4(2\pi-5)}{ \pi^3}&
k_{5\ 1\ 5}&=\frac{16( \pi-3)}{ \pi^5}\\
k_{5\ 2\ 1}&=\frac{ 48-  9\pi}{2\pi^2}&
k_{5\ 2\ 3}&=\frac{192- 56\pi}{ \pi^4}&
k_{5\ 2\ 5}&=\frac{384-120\pi}{ \pi^6}
\end{align*}
$$

$$
\begin{align*}
ik_{5\ 1\ 1}&=\lceil  32768\ k_{5\ 1\ 1}      \frac{\pi}{2}          \rceil &&=51472\\
ik_{5\ 1\ 3}&=\lceil  32768\ k_{5\ 1\ 3}\left(\frac{\pi}{2}\right)^3 \rceil &&=21024\\
ik_{5\ 1\ 5}&=\lceil  32768\ k_{5\ 1\ 5}\left(\frac{\pi}{2}\right)^5 \rceil &&= 2320\\
ik_{5\ 2\ 1}&=\lfloor 32768\ k_{5\ 2\ 1}      \frac{\pi}{2}          \rfloor&&=51436\\
ik_{5\ 2\ 3}&=\lfloor 32768\ k_{5\ 2\ 3}\left(\frac{\pi}{2}\right)^3 \rfloor&&=20953\\
ik_{5\ 2\ 5}&=\lfloor 32768\ k_{5\ 2\ 5}\left(\frac{\pi}{2}\right)^5 \rfloor&&= 2284
\end{align*}
$$

$c=1$ か $c=2$ かで丸め方向が異なるが､ これは丸めた時の差を小さくするため｡
$x=0$ ､ $x=\frac{\pi}{2}$ の時に精確に $1$ または $0$ にするため､
$ik_{5\ c\ 1}-(ik_{5\ c\ 3}-ik_{5\ c\ 5})=32768$ にしなければならない｡

## atan

wip

## asin and acos

wip

## Reference

1. <span id="abramowitz-and-stegun">^</span> <sup>[a](#abramowitz-and-stegun-a)</sup> Milton Abramowitz and Irene Stegun . Handbook of Mathematical Function With Formulas, Graphs, and Mathematical Tables (Abramowitz and Stegun) . United States Department of Commerce, National Bureau of Standards (NBS) , 1964

- Another fast fixed-point sine approximation | Coranac
  - http://www.coranac.com/2009/07/sines/
  - http://web.archive.org/web/20240629132053/http://www.coranac.com/2009/07/sines/
