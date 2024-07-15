using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public partial struct QuaternionI17F15 : IEquatable<QuaternionI17F15>, IFormattable {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4I17F15 XYZW;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Properties
        // ---------------------------------------

        public I17F15 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => XYZW.X;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.X = value;
        }
        public I17F15 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => XYZW.Y;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.Y = value;
        }
        public I17F15 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => XYZW.Z;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.Z = value;
        }
        public I17F15 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => XYZW.W;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.W = value;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15(Vector4I17F15 xyzw) => XYZW = xyzw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15(I17F15 x, I17F15 y, I17F15 z, I17F15 w) : this(
            new Vector4I17F15(x, y, z, w)
        ) { }

        // Static Properties
        // ---------------------------------------

        public static QuaternionI17F15 Identity {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new QuaternionI17F15(Vector4I17F15.UnitW);
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(QuaternionI17F15 left, QuaternionI17F15 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(QuaternionI17F15 left, QuaternionI17F15 right) => !(left == right);

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP5A51437(Vector3I17F15 xyz) {
            var half = xyz.Half();
            var s = half.SinP5A51437();
            var c = half.CosP5A51437();
            const int k = 1 << 10;

            // Convert to 44 integer bits and 20 fractional bits.
            // It is commutative about the order of the multiplication
            // while ensuring maximum precision.
            long sx = s.X.Bits / k;
            long sy = s.Y.Bits / k;
            long sz = s.Z.Bits / k;
            long cx = c.X.Bits / k;
            long cy = c.Y.Bits / k;
            long cz = c.Z.Bits / k;

            const long l = 1L << 45;

            // s.x * c.y * c.z + s.y * s.z * c.x,
            // s.y * c.z * c.x - s.z * s.x * c.y,
            // s.z * c.x * c.y - s.x * s.y * c.z,
            // c.x * c.y * c.z + s.y * s.z * s.x
            return new QuaternionI17F15(
                I17F15.FromBits((int)(((sx * cy * cz) + (sy * sz * cx)) / l)),
                I17F15.FromBits((int)(((sy * cz * cx) - (sz * sx * cy)) / l)),
                I17F15.FromBits((int)(((sz * cx * cy) - (sx * sy * cz)) / l)),
                I17F15.FromBits((int)(((cx * cy * cz) + (sy * sz * sx)) / l)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP5A51437(I17F15 x, I17F15 y, I17F15 z) => EulerZxyP5A51437(new Vector3I17F15(x, y, z));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is QuaternionI17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{{X:{X} Y:{Y} Z:{Z} W:{W}}}";

        // IEquatable<QuaternionI17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(QuaternionI17F15 other) => XYZW.Equals(other.XYZW);

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            var w = W.ToString(format, formatProvider);
            return $"{{X:{x} Y:{y} Z:{z} W:{w}}}";
        }

    }
}
