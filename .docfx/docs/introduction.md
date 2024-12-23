# はじめに

Intar は整数演算のみを使って実装された座標システムを提供するライブラリです｡

主にゲームのリプレイ機能などで､ 異なる言語や､ 異なるゲームエンジンに移植した時にも同じリプレイファイルで同じ状態を再現可能にすることをその目標とします｡

## ライセンス

[MIT License でご利用いただけます](https://github.com/agate-pris/intar/blob/main/LICENSE.md) ｡

> [!IMPORTANT]
>
> v0.27.0 から CC0 1.0 から MIT License に変更しました。

## 機能

以下の機能は実装済みです｡

- 特殊関数
  - Sin ､ Cos
  - Atan ､ Atan2
  - Acos ､ Asin
- 乱数
  - Xoroshiro128**
- 固定小数点数
- ベクトル
- オーバーフローを取り扱う機能
- ビット演算
  - `LeadingZeroCount`
  - `PopCount`
  - `RotateLeft`
  - `RotateRight`

以下の機能は未実装 (実装予定) です｡

- 行列
- クォータニオン
- トランスフォーム
- スプライン
- あたり判定

以下の機能を実装するか否かについては未定です｡

- 乱数
  - [暗号論的擬似乱数生成器](https://ja.wikipedia.org/wiki/%E6%9A%97%E5%8F%B7%E8%AB%96%E7%9A%84%E6%93%AC%E4%BC%BC%E4%B9%B1%E6%95%B0%E7%94%9F%E6%88%90%E5%99%A8)
- Physics 2D
- Physics 3D

## 設計理念

Intar は「再現可能」「移植可能」を念頭に設計されています｡

そのため､ その実装は以下のような処理系に対して移植可能なように作られています｡

- 整数の除算と剰余算について､ その正負に関わらず 0 方向へと丸めるそれを実装する｡
- 最大値が $2^{31} - 1$ 以上､ 最小値が $-(2^{31}-1)$ 以下の整数型を持つ｡
- 最大値が $2^{63} - 1$ 以上､ 最小値が $-(2^{63}-1)$ 以下の整数型を持つ｡
- 最大値が $2^{32} - 1$ 以上の整数型を持つ。
- 最大値が $2^{64} - 1$ 以上の整数型を持つ。

これは、C99 [^c99] の以下の文面に基づくものです。

> 5.2.4.2.1 Sizes of integer types <limits.h>
>
> ... Their implementation-defined values shall be equal or greater
> in magnitude (absolute value) to those shown, with the same sign.

> ```
> LONG_MIN            -2147483647 // -(2^31 - 1)
> LONG_MAX            +2147483647 //   2^31 - 1
> ULONG_MAX            4294967295 //   2^32 - 1
> LLONG_MIN  -9223372036854775807 // -(2^63 - 1)
> LLONG_MAX  +9223372036854775807 //   2^63 - 1
> ULLONG_MAX 18446744073709551615 //   2^64 - 1
> ```

> 6.5.5 Multiplicative operators

> 6. When integers are divided the result of the `/` operator is the algebraic quotient with any fractional part discarded.<sup>90)</sup> If the quoteient `a/b` is representable, the expression `(a/b) *b + a%b` shall equal `a`.

> 90) This is often called "truncation toward zero".

以下のような処理系については明示的にサポートしません｡

- 整数の表現範囲に 0 が含まれない｡
- 整数の表現範囲が飛び飛びである｡

[^c99]: ISO/IEC 9899:1999 (C99)
- https://www.open-std.org/jtc1/sc22/wg14/www/projects
- https://www.open-std.org/jtc1/sc22/wg14/www/docs/n1548.pdf
