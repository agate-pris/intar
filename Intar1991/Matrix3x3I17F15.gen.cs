using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct Matrix3x3I17F15 : IEquatable<Matrix3x3I17F15> {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Vector3Int32 C0Repr;
        public Vector3Int32 C1Repr;
        public Vector3Int32 C2Repr;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I17F15(Vector3Int32 c0Repr, Vector3Int32 c1Repr, Vector3Int32 c2Repr) {
            C0Repr = c0Repr;
            C1Repr = c1Repr;
            C2Repr = c2Repr;
        }
        #endregion
        #region Properties
        public Vector3I17F15 C0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(C0Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C0Repr = value.Repr;
        }
        public Vector3I17F15 C1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(C1Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C1Repr = value.Repr;
        }
        public Vector3I17F15 C2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(C2Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C2Repr = value.Repr;
        }
        public Vector3I17F15 R0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(new Vector3Int32(C0Repr.X, C1Repr.X, C2Repr.X));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0Repr.X = value.Repr.X;
                C1Repr.X = value.Repr.Y;
                C2Repr.X = value.Repr.Z;
            }
        }
        public Vector3I17F15 R1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(new Vector3Int32(C0Repr.Y, C1Repr.Y, C2Repr.Y));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0Repr.Y = value.Repr.X;
                C1Repr.Y = value.Repr.Y;
                C2Repr.Y = value.Repr.Z;
            }
        }
        public Vector3I17F15 R2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(new Vector3Int32(C0Repr.Z, C1Repr.Z, C2Repr.Z));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0Repr.Z = value.Repr.X;
                C1Repr.Z = value.Repr.Y;
                C2Repr.Z = value.Repr.Z;
            }
        }
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Matrix3x3I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0Repr, C1Repr, C2Repr);
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix3x3I17F15 other) =>
            C0Repr.Equals(other.C0Repr) &&
            C1Repr.Equals(other.C1Repr) &&
            C2Repr.Equals(other.C2Repr);
        #endregion
    }
} // namespace Intar1991
