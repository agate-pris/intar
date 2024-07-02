using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class VectorExtension {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingAdd(
            this Vector2I2F30 x, Vector2I2F30 y
        ) => new Vector2I2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingAdd(
            this Vector3I2F30 x, Vector3I2F30 y
        ) => new Vector3I2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingAdd(
            this Vector4I2F30 x, Vector4I2F30 y
        ) => new Vector4I2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingAdd(
            this Vector2I3F29 x, Vector2I3F29 y
        ) => new Vector2I3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingAdd(
            this Vector3I3F29 x, Vector3I3F29 y
        ) => new Vector3I3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingAdd(
            this Vector4I3F29 x, Vector4I3F29 y
        ) => new Vector4I3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingAdd(
            this Vector2I4F28 x, Vector2I4F28 y
        ) => new Vector2I4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingAdd(
            this Vector3I4F28 x, Vector3I4F28 y
        ) => new Vector3I4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingAdd(
            this Vector4I4F28 x, Vector4I4F28 y
        ) => new Vector4I4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingAdd(
            this Vector2I5F27 x, Vector2I5F27 y
        ) => new Vector2I5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingAdd(
            this Vector3I5F27 x, Vector3I5F27 y
        ) => new Vector3I5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingAdd(
            this Vector4I5F27 x, Vector4I5F27 y
        ) => new Vector4I5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingAdd(
            this Vector2I6F26 x, Vector2I6F26 y
        ) => new Vector2I6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingAdd(
            this Vector3I6F26 x, Vector3I6F26 y
        ) => new Vector3I6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingAdd(
            this Vector4I6F26 x, Vector4I6F26 y
        ) => new Vector4I6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingAdd(
            this Vector2I7F25 x, Vector2I7F25 y
        ) => new Vector2I7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingAdd(
            this Vector3I7F25 x, Vector3I7F25 y
        ) => new Vector3I7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingAdd(
            this Vector4I7F25 x, Vector4I7F25 y
        ) => new Vector4I7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingAdd(
            this Vector2I8F24 x, Vector2I8F24 y
        ) => new Vector2I8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingAdd(
            this Vector3I8F24 x, Vector3I8F24 y
        ) => new Vector3I8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingAdd(
            this Vector4I8F24 x, Vector4I8F24 y
        ) => new Vector4I8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingAdd(
            this Vector2I9F23 x, Vector2I9F23 y
        ) => new Vector2I9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingAdd(
            this Vector3I9F23 x, Vector3I9F23 y
        ) => new Vector3I9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingAdd(
            this Vector4I9F23 x, Vector4I9F23 y
        ) => new Vector4I9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingAdd(
            this Vector2I10F22 x, Vector2I10F22 y
        ) => new Vector2I10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingAdd(
            this Vector3I10F22 x, Vector3I10F22 y
        ) => new Vector3I10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingAdd(
            this Vector4I10F22 x, Vector4I10F22 y
        ) => new Vector4I10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingAdd(
            this Vector2I11F21 x, Vector2I11F21 y
        ) => new Vector2I11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingAdd(
            this Vector3I11F21 x, Vector3I11F21 y
        ) => new Vector3I11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingAdd(
            this Vector4I11F21 x, Vector4I11F21 y
        ) => new Vector4I11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingAdd(
            this Vector2I12F20 x, Vector2I12F20 y
        ) => new Vector2I12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingAdd(
            this Vector3I12F20 x, Vector3I12F20 y
        ) => new Vector3I12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingAdd(
            this Vector4I12F20 x, Vector4I12F20 y
        ) => new Vector4I12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingAdd(
            this Vector2I13F19 x, Vector2I13F19 y
        ) => new Vector2I13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingAdd(
            this Vector3I13F19 x, Vector3I13F19 y
        ) => new Vector3I13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingAdd(
            this Vector4I13F19 x, Vector4I13F19 y
        ) => new Vector4I13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingAdd(
            this Vector2I14F18 x, Vector2I14F18 y
        ) => new Vector2I14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingAdd(
            this Vector3I14F18 x, Vector3I14F18 y
        ) => new Vector3I14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingAdd(
            this Vector4I14F18 x, Vector4I14F18 y
        ) => new Vector4I14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingAdd(
            this Vector2I15F17 x, Vector2I15F17 y
        ) => new Vector2I15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingAdd(
            this Vector3I15F17 x, Vector3I15F17 y
        ) => new Vector3I15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingAdd(
            this Vector4I15F17 x, Vector4I15F17 y
        ) => new Vector4I15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingAdd(
            this Vector2I16F16 x, Vector2I16F16 y
        ) => new Vector2I16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingAdd(
            this Vector3I16F16 x, Vector3I16F16 y
        ) => new Vector3I16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingAdd(
            this Vector4I16F16 x, Vector4I16F16 y
        ) => new Vector4I16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingAdd(
            this Vector2I17F15 x, Vector2I17F15 y
        ) => new Vector2I17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingAdd(
            this Vector3I17F15 x, Vector3I17F15 y
        ) => new Vector3I17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingAdd(
            this Vector4I17F15 x, Vector4I17F15 y
        ) => new Vector4I17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingAdd(
            this Vector2I18F14 x, Vector2I18F14 y
        ) => new Vector2I18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingAdd(
            this Vector3I18F14 x, Vector3I18F14 y
        ) => new Vector3I18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingAdd(
            this Vector4I18F14 x, Vector4I18F14 y
        ) => new Vector4I18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingAdd(
            this Vector2I19F13 x, Vector2I19F13 y
        ) => new Vector2I19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingAdd(
            this Vector3I19F13 x, Vector3I19F13 y
        ) => new Vector3I19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingAdd(
            this Vector4I19F13 x, Vector4I19F13 y
        ) => new Vector4I19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingAdd(
            this Vector2I20F12 x, Vector2I20F12 y
        ) => new Vector2I20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingAdd(
            this Vector3I20F12 x, Vector3I20F12 y
        ) => new Vector3I20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingAdd(
            this Vector4I20F12 x, Vector4I20F12 y
        ) => new Vector4I20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingAdd(
            this Vector2I21F11 x, Vector2I21F11 y
        ) => new Vector2I21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingAdd(
            this Vector3I21F11 x, Vector3I21F11 y
        ) => new Vector3I21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingAdd(
            this Vector4I21F11 x, Vector4I21F11 y
        ) => new Vector4I21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingAdd(
            this Vector2I22F10 x, Vector2I22F10 y
        ) => new Vector2I22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingAdd(
            this Vector3I22F10 x, Vector3I22F10 y
        ) => new Vector3I22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingAdd(
            this Vector4I22F10 x, Vector4I22F10 y
        ) => new Vector4I22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingAdd(
            this Vector2I23F9 x, Vector2I23F9 y
        ) => new Vector2I23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingAdd(
            this Vector3I23F9 x, Vector3I23F9 y
        ) => new Vector3I23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingAdd(
            this Vector4I23F9 x, Vector4I23F9 y
        ) => new Vector4I23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingAdd(
            this Vector2I24F8 x, Vector2I24F8 y
        ) => new Vector2I24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingAdd(
            this Vector3I24F8 x, Vector3I24F8 y
        ) => new Vector3I24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingAdd(
            this Vector4I24F8 x, Vector4I24F8 y
        ) => new Vector4I24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingAdd(
            this Vector2I25F7 x, Vector2I25F7 y
        ) => new Vector2I25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingAdd(
            this Vector3I25F7 x, Vector3I25F7 y
        ) => new Vector3I25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingAdd(
            this Vector4I25F7 x, Vector4I25F7 y
        ) => new Vector4I25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingAdd(
            this Vector2I26F6 x, Vector2I26F6 y
        ) => new Vector2I26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingAdd(
            this Vector3I26F6 x, Vector3I26F6 y
        ) => new Vector3I26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingAdd(
            this Vector4I26F6 x, Vector4I26F6 y
        ) => new Vector4I26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingAdd(
            this Vector2I27F5 x, Vector2I27F5 y
        ) => new Vector2I27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingAdd(
            this Vector3I27F5 x, Vector3I27F5 y
        ) => new Vector3I27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingAdd(
            this Vector4I27F5 x, Vector4I27F5 y
        ) => new Vector4I27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingAdd(
            this Vector2I28F4 x, Vector2I28F4 y
        ) => new Vector2I28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingAdd(
            this Vector3I28F4 x, Vector3I28F4 y
        ) => new Vector3I28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingAdd(
            this Vector4I28F4 x, Vector4I28F4 y
        ) => new Vector4I28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingAdd(
            this Vector2I29F3 x, Vector2I29F3 y
        ) => new Vector2I29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingAdd(
            this Vector3I29F3 x, Vector3I29F3 y
        ) => new Vector3I29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingAdd(
            this Vector4I29F3 x, Vector4I29F3 y
        ) => new Vector4I29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingAdd(
            this Vector2I30F2 x, Vector2I30F2 y
        ) => new Vector2I30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingAdd(
            this Vector3I30F2 x, Vector3I30F2 y
        ) => new Vector3I30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingAdd(
            this Vector4I30F2 x, Vector4I30F2 y
        ) => new Vector4I30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingAdd(
            this Vector2I31F1 x, Vector2I31F1 y
        ) => new Vector2I31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingAdd(
            this Vector3I31F1 x, Vector3I31F1 y
        ) => new Vector3I31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingAdd(
            this Vector4I31F1 x, Vector4I31F1 y
        ) => new Vector4I31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingAdd(
            this Vector2U2F30 x, Vector2U2F30 y
        ) => new Vector2U2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingAdd(
            this Vector3U2F30 x, Vector3U2F30 y
        ) => new Vector3U2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingAdd(
            this Vector4U2F30 x, Vector4U2F30 y
        ) => new Vector4U2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingAdd(
            this Vector2U3F29 x, Vector2U3F29 y
        ) => new Vector2U3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingAdd(
            this Vector3U3F29 x, Vector3U3F29 y
        ) => new Vector3U3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingAdd(
            this Vector4U3F29 x, Vector4U3F29 y
        ) => new Vector4U3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingAdd(
            this Vector2U4F28 x, Vector2U4F28 y
        ) => new Vector2U4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingAdd(
            this Vector3U4F28 x, Vector3U4F28 y
        ) => new Vector3U4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingAdd(
            this Vector4U4F28 x, Vector4U4F28 y
        ) => new Vector4U4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingAdd(
            this Vector2U5F27 x, Vector2U5F27 y
        ) => new Vector2U5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingAdd(
            this Vector3U5F27 x, Vector3U5F27 y
        ) => new Vector3U5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingAdd(
            this Vector4U5F27 x, Vector4U5F27 y
        ) => new Vector4U5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingAdd(
            this Vector2U6F26 x, Vector2U6F26 y
        ) => new Vector2U6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingAdd(
            this Vector3U6F26 x, Vector3U6F26 y
        ) => new Vector3U6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingAdd(
            this Vector4U6F26 x, Vector4U6F26 y
        ) => new Vector4U6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingAdd(
            this Vector2U7F25 x, Vector2U7F25 y
        ) => new Vector2U7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingAdd(
            this Vector3U7F25 x, Vector3U7F25 y
        ) => new Vector3U7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingAdd(
            this Vector4U7F25 x, Vector4U7F25 y
        ) => new Vector4U7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingAdd(
            this Vector2U8F24 x, Vector2U8F24 y
        ) => new Vector2U8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingAdd(
            this Vector3U8F24 x, Vector3U8F24 y
        ) => new Vector3U8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingAdd(
            this Vector4U8F24 x, Vector4U8F24 y
        ) => new Vector4U8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingAdd(
            this Vector2U9F23 x, Vector2U9F23 y
        ) => new Vector2U9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingAdd(
            this Vector3U9F23 x, Vector3U9F23 y
        ) => new Vector3U9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingAdd(
            this Vector4U9F23 x, Vector4U9F23 y
        ) => new Vector4U9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingAdd(
            this Vector2U10F22 x, Vector2U10F22 y
        ) => new Vector2U10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingAdd(
            this Vector3U10F22 x, Vector3U10F22 y
        ) => new Vector3U10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingAdd(
            this Vector4U10F22 x, Vector4U10F22 y
        ) => new Vector4U10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingAdd(
            this Vector2U11F21 x, Vector2U11F21 y
        ) => new Vector2U11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingAdd(
            this Vector3U11F21 x, Vector3U11F21 y
        ) => new Vector3U11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingAdd(
            this Vector4U11F21 x, Vector4U11F21 y
        ) => new Vector4U11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingAdd(
            this Vector2U12F20 x, Vector2U12F20 y
        ) => new Vector2U12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingAdd(
            this Vector3U12F20 x, Vector3U12F20 y
        ) => new Vector3U12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingAdd(
            this Vector4U12F20 x, Vector4U12F20 y
        ) => new Vector4U12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingAdd(
            this Vector2U13F19 x, Vector2U13F19 y
        ) => new Vector2U13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingAdd(
            this Vector3U13F19 x, Vector3U13F19 y
        ) => new Vector3U13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingAdd(
            this Vector4U13F19 x, Vector4U13F19 y
        ) => new Vector4U13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingAdd(
            this Vector2U14F18 x, Vector2U14F18 y
        ) => new Vector2U14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingAdd(
            this Vector3U14F18 x, Vector3U14F18 y
        ) => new Vector3U14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingAdd(
            this Vector4U14F18 x, Vector4U14F18 y
        ) => new Vector4U14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingAdd(
            this Vector2U15F17 x, Vector2U15F17 y
        ) => new Vector2U15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingAdd(
            this Vector3U15F17 x, Vector3U15F17 y
        ) => new Vector3U15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingAdd(
            this Vector4U15F17 x, Vector4U15F17 y
        ) => new Vector4U15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingAdd(
            this Vector2U16F16 x, Vector2U16F16 y
        ) => new Vector2U16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingAdd(
            this Vector3U16F16 x, Vector3U16F16 y
        ) => new Vector3U16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingAdd(
            this Vector4U16F16 x, Vector4U16F16 y
        ) => new Vector4U16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingAdd(
            this Vector2U17F15 x, Vector2U17F15 y
        ) => new Vector2U17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingAdd(
            this Vector3U17F15 x, Vector3U17F15 y
        ) => new Vector3U17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingAdd(
            this Vector4U17F15 x, Vector4U17F15 y
        ) => new Vector4U17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingAdd(
            this Vector2U18F14 x, Vector2U18F14 y
        ) => new Vector2U18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingAdd(
            this Vector3U18F14 x, Vector3U18F14 y
        ) => new Vector3U18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingAdd(
            this Vector4U18F14 x, Vector4U18F14 y
        ) => new Vector4U18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingAdd(
            this Vector2U19F13 x, Vector2U19F13 y
        ) => new Vector2U19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingAdd(
            this Vector3U19F13 x, Vector3U19F13 y
        ) => new Vector3U19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingAdd(
            this Vector4U19F13 x, Vector4U19F13 y
        ) => new Vector4U19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingAdd(
            this Vector2U20F12 x, Vector2U20F12 y
        ) => new Vector2U20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingAdd(
            this Vector3U20F12 x, Vector3U20F12 y
        ) => new Vector3U20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingAdd(
            this Vector4U20F12 x, Vector4U20F12 y
        ) => new Vector4U20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingAdd(
            this Vector2U21F11 x, Vector2U21F11 y
        ) => new Vector2U21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingAdd(
            this Vector3U21F11 x, Vector3U21F11 y
        ) => new Vector3U21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingAdd(
            this Vector4U21F11 x, Vector4U21F11 y
        ) => new Vector4U21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingAdd(
            this Vector2U22F10 x, Vector2U22F10 y
        ) => new Vector2U22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingAdd(
            this Vector3U22F10 x, Vector3U22F10 y
        ) => new Vector3U22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingAdd(
            this Vector4U22F10 x, Vector4U22F10 y
        ) => new Vector4U22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingAdd(
            this Vector2U23F9 x, Vector2U23F9 y
        ) => new Vector2U23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingAdd(
            this Vector3U23F9 x, Vector3U23F9 y
        ) => new Vector3U23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingAdd(
            this Vector4U23F9 x, Vector4U23F9 y
        ) => new Vector4U23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingAdd(
            this Vector2U24F8 x, Vector2U24F8 y
        ) => new Vector2U24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingAdd(
            this Vector3U24F8 x, Vector3U24F8 y
        ) => new Vector3U24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingAdd(
            this Vector4U24F8 x, Vector4U24F8 y
        ) => new Vector4U24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingAdd(
            this Vector2U25F7 x, Vector2U25F7 y
        ) => new Vector2U25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingAdd(
            this Vector3U25F7 x, Vector3U25F7 y
        ) => new Vector3U25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingAdd(
            this Vector4U25F7 x, Vector4U25F7 y
        ) => new Vector4U25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingAdd(
            this Vector2U26F6 x, Vector2U26F6 y
        ) => new Vector2U26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingAdd(
            this Vector3U26F6 x, Vector3U26F6 y
        ) => new Vector3U26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingAdd(
            this Vector4U26F6 x, Vector4U26F6 y
        ) => new Vector4U26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingAdd(
            this Vector2U27F5 x, Vector2U27F5 y
        ) => new Vector2U27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingAdd(
            this Vector3U27F5 x, Vector3U27F5 y
        ) => new Vector3U27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingAdd(
            this Vector4U27F5 x, Vector4U27F5 y
        ) => new Vector4U27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingAdd(
            this Vector2U28F4 x, Vector2U28F4 y
        ) => new Vector2U28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingAdd(
            this Vector3U28F4 x, Vector3U28F4 y
        ) => new Vector3U28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingAdd(
            this Vector4U28F4 x, Vector4U28F4 y
        ) => new Vector4U28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingAdd(
            this Vector2U29F3 x, Vector2U29F3 y
        ) => new Vector2U29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingAdd(
            this Vector3U29F3 x, Vector3U29F3 y
        ) => new Vector3U29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingAdd(
            this Vector4U29F3 x, Vector4U29F3 y
        ) => new Vector4U29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingAdd(
            this Vector2U30F2 x, Vector2U30F2 y
        ) => new Vector2U30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingAdd(
            this Vector3U30F2 x, Vector3U30F2 y
        ) => new Vector3U30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingAdd(
            this Vector4U30F2 x, Vector4U30F2 y
        ) => new Vector4U30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingAdd(
            this Vector2U31F1 x, Vector2U31F1 y
        ) => new Vector2U31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingAdd(
            this Vector3U31F1 x, Vector3U31F1 y
        ) => new Vector3U31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingAdd(
            this Vector4U31F1 x, Vector4U31F1 y
        ) => new Vector4U31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingMul(
            this I2F30 x, Vector2I2F30 y
        ) => new Vector2I2F30(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingMul(
            this Vector2I2F30 x, I2F30 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingMul(
            this I2F30 x, Vector3I2F30 y
        ) => new Vector3I2F30(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingMul(
            this Vector3I2F30 x, I2F30 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingMul(
            this I2F30 x, Vector4I2F30 y
        ) => new Vector4I2F30(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingMul(
            this Vector4I2F30 x, I2F30 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingMul(
            this I3F29 x, Vector2I3F29 y
        ) => new Vector2I3F29(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingMul(
            this Vector2I3F29 x, I3F29 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingMul(
            this I3F29 x, Vector3I3F29 y
        ) => new Vector3I3F29(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingMul(
            this Vector3I3F29 x, I3F29 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingMul(
            this I3F29 x, Vector4I3F29 y
        ) => new Vector4I3F29(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingMul(
            this Vector4I3F29 x, I3F29 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingMul(
            this I4F28 x, Vector2I4F28 y
        ) => new Vector2I4F28(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingMul(
            this Vector2I4F28 x, I4F28 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingMul(
            this I4F28 x, Vector3I4F28 y
        ) => new Vector3I4F28(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingMul(
            this Vector3I4F28 x, I4F28 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingMul(
            this I4F28 x, Vector4I4F28 y
        ) => new Vector4I4F28(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingMul(
            this Vector4I4F28 x, I4F28 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingMul(
            this I5F27 x, Vector2I5F27 y
        ) => new Vector2I5F27(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingMul(
            this Vector2I5F27 x, I5F27 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingMul(
            this I5F27 x, Vector3I5F27 y
        ) => new Vector3I5F27(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingMul(
            this Vector3I5F27 x, I5F27 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingMul(
            this I5F27 x, Vector4I5F27 y
        ) => new Vector4I5F27(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingMul(
            this Vector4I5F27 x, I5F27 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingMul(
            this I6F26 x, Vector2I6F26 y
        ) => new Vector2I6F26(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingMul(
            this Vector2I6F26 x, I6F26 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingMul(
            this I6F26 x, Vector3I6F26 y
        ) => new Vector3I6F26(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingMul(
            this Vector3I6F26 x, I6F26 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingMul(
            this I6F26 x, Vector4I6F26 y
        ) => new Vector4I6F26(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingMul(
            this Vector4I6F26 x, I6F26 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingMul(
            this I7F25 x, Vector2I7F25 y
        ) => new Vector2I7F25(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingMul(
            this Vector2I7F25 x, I7F25 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingMul(
            this I7F25 x, Vector3I7F25 y
        ) => new Vector3I7F25(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingMul(
            this Vector3I7F25 x, I7F25 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingMul(
            this I7F25 x, Vector4I7F25 y
        ) => new Vector4I7F25(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingMul(
            this Vector4I7F25 x, I7F25 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingMul(
            this I8F24 x, Vector2I8F24 y
        ) => new Vector2I8F24(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingMul(
            this Vector2I8F24 x, I8F24 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingMul(
            this I8F24 x, Vector3I8F24 y
        ) => new Vector3I8F24(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingMul(
            this Vector3I8F24 x, I8F24 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingMul(
            this I8F24 x, Vector4I8F24 y
        ) => new Vector4I8F24(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingMul(
            this Vector4I8F24 x, I8F24 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingMul(
            this I9F23 x, Vector2I9F23 y
        ) => new Vector2I9F23(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingMul(
            this Vector2I9F23 x, I9F23 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingMul(
            this I9F23 x, Vector3I9F23 y
        ) => new Vector3I9F23(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingMul(
            this Vector3I9F23 x, I9F23 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingMul(
            this I9F23 x, Vector4I9F23 y
        ) => new Vector4I9F23(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingMul(
            this Vector4I9F23 x, I9F23 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingMul(
            this I10F22 x, Vector2I10F22 y
        ) => new Vector2I10F22(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingMul(
            this Vector2I10F22 x, I10F22 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingMul(
            this I10F22 x, Vector3I10F22 y
        ) => new Vector3I10F22(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingMul(
            this Vector3I10F22 x, I10F22 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingMul(
            this I10F22 x, Vector4I10F22 y
        ) => new Vector4I10F22(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingMul(
            this Vector4I10F22 x, I10F22 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingMul(
            this I11F21 x, Vector2I11F21 y
        ) => new Vector2I11F21(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingMul(
            this Vector2I11F21 x, I11F21 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingMul(
            this I11F21 x, Vector3I11F21 y
        ) => new Vector3I11F21(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingMul(
            this Vector3I11F21 x, I11F21 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingMul(
            this I11F21 x, Vector4I11F21 y
        ) => new Vector4I11F21(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingMul(
            this Vector4I11F21 x, I11F21 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingMul(
            this I12F20 x, Vector2I12F20 y
        ) => new Vector2I12F20(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingMul(
            this Vector2I12F20 x, I12F20 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingMul(
            this I12F20 x, Vector3I12F20 y
        ) => new Vector3I12F20(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingMul(
            this Vector3I12F20 x, I12F20 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingMul(
            this I12F20 x, Vector4I12F20 y
        ) => new Vector4I12F20(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingMul(
            this Vector4I12F20 x, I12F20 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingMul(
            this I13F19 x, Vector2I13F19 y
        ) => new Vector2I13F19(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingMul(
            this Vector2I13F19 x, I13F19 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingMul(
            this I13F19 x, Vector3I13F19 y
        ) => new Vector3I13F19(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingMul(
            this Vector3I13F19 x, I13F19 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingMul(
            this I13F19 x, Vector4I13F19 y
        ) => new Vector4I13F19(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingMul(
            this Vector4I13F19 x, I13F19 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingMul(
            this I14F18 x, Vector2I14F18 y
        ) => new Vector2I14F18(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingMul(
            this Vector2I14F18 x, I14F18 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingMul(
            this I14F18 x, Vector3I14F18 y
        ) => new Vector3I14F18(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingMul(
            this Vector3I14F18 x, I14F18 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingMul(
            this I14F18 x, Vector4I14F18 y
        ) => new Vector4I14F18(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingMul(
            this Vector4I14F18 x, I14F18 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingMul(
            this I15F17 x, Vector2I15F17 y
        ) => new Vector2I15F17(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingMul(
            this Vector2I15F17 x, I15F17 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingMul(
            this I15F17 x, Vector3I15F17 y
        ) => new Vector3I15F17(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingMul(
            this Vector3I15F17 x, I15F17 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingMul(
            this I15F17 x, Vector4I15F17 y
        ) => new Vector4I15F17(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingMul(
            this Vector4I15F17 x, I15F17 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingMul(
            this I16F16 x, Vector2I16F16 y
        ) => new Vector2I16F16(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingMul(
            this Vector2I16F16 x, I16F16 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingMul(
            this I16F16 x, Vector3I16F16 y
        ) => new Vector3I16F16(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingMul(
            this Vector3I16F16 x, I16F16 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingMul(
            this I16F16 x, Vector4I16F16 y
        ) => new Vector4I16F16(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingMul(
            this Vector4I16F16 x, I16F16 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingMul(
            this I17F15 x, Vector2I17F15 y
        ) => new Vector2I17F15(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingMul(
            this Vector2I17F15 x, I17F15 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingMul(
            this I17F15 x, Vector3I17F15 y
        ) => new Vector3I17F15(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingMul(
            this Vector3I17F15 x, I17F15 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingMul(
            this I17F15 x, Vector4I17F15 y
        ) => new Vector4I17F15(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingMul(
            this Vector4I17F15 x, I17F15 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingMul(
            this I18F14 x, Vector2I18F14 y
        ) => new Vector2I18F14(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingMul(
            this Vector2I18F14 x, I18F14 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingMul(
            this I18F14 x, Vector3I18F14 y
        ) => new Vector3I18F14(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingMul(
            this Vector3I18F14 x, I18F14 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingMul(
            this I18F14 x, Vector4I18F14 y
        ) => new Vector4I18F14(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingMul(
            this Vector4I18F14 x, I18F14 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingMul(
            this I19F13 x, Vector2I19F13 y
        ) => new Vector2I19F13(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingMul(
            this Vector2I19F13 x, I19F13 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingMul(
            this I19F13 x, Vector3I19F13 y
        ) => new Vector3I19F13(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingMul(
            this Vector3I19F13 x, I19F13 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingMul(
            this I19F13 x, Vector4I19F13 y
        ) => new Vector4I19F13(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingMul(
            this Vector4I19F13 x, I19F13 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingMul(
            this I20F12 x, Vector2I20F12 y
        ) => new Vector2I20F12(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingMul(
            this Vector2I20F12 x, I20F12 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingMul(
            this I20F12 x, Vector3I20F12 y
        ) => new Vector3I20F12(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingMul(
            this Vector3I20F12 x, I20F12 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingMul(
            this I20F12 x, Vector4I20F12 y
        ) => new Vector4I20F12(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingMul(
            this Vector4I20F12 x, I20F12 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingMul(
            this I21F11 x, Vector2I21F11 y
        ) => new Vector2I21F11(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingMul(
            this Vector2I21F11 x, I21F11 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingMul(
            this I21F11 x, Vector3I21F11 y
        ) => new Vector3I21F11(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingMul(
            this Vector3I21F11 x, I21F11 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingMul(
            this I21F11 x, Vector4I21F11 y
        ) => new Vector4I21F11(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingMul(
            this Vector4I21F11 x, I21F11 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingMul(
            this I22F10 x, Vector2I22F10 y
        ) => new Vector2I22F10(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingMul(
            this Vector2I22F10 x, I22F10 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingMul(
            this I22F10 x, Vector3I22F10 y
        ) => new Vector3I22F10(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingMul(
            this Vector3I22F10 x, I22F10 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingMul(
            this I22F10 x, Vector4I22F10 y
        ) => new Vector4I22F10(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingMul(
            this Vector4I22F10 x, I22F10 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingMul(
            this I23F9 x, Vector2I23F9 y
        ) => new Vector2I23F9(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingMul(
            this Vector2I23F9 x, I23F9 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingMul(
            this I23F9 x, Vector3I23F9 y
        ) => new Vector3I23F9(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingMul(
            this Vector3I23F9 x, I23F9 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingMul(
            this I23F9 x, Vector4I23F9 y
        ) => new Vector4I23F9(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingMul(
            this Vector4I23F9 x, I23F9 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingMul(
            this I24F8 x, Vector2I24F8 y
        ) => new Vector2I24F8(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingMul(
            this Vector2I24F8 x, I24F8 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingMul(
            this I24F8 x, Vector3I24F8 y
        ) => new Vector3I24F8(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingMul(
            this Vector3I24F8 x, I24F8 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingMul(
            this I24F8 x, Vector4I24F8 y
        ) => new Vector4I24F8(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingMul(
            this Vector4I24F8 x, I24F8 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingMul(
            this I25F7 x, Vector2I25F7 y
        ) => new Vector2I25F7(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingMul(
            this Vector2I25F7 x, I25F7 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingMul(
            this I25F7 x, Vector3I25F7 y
        ) => new Vector3I25F7(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingMul(
            this Vector3I25F7 x, I25F7 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingMul(
            this I25F7 x, Vector4I25F7 y
        ) => new Vector4I25F7(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingMul(
            this Vector4I25F7 x, I25F7 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingMul(
            this I26F6 x, Vector2I26F6 y
        ) => new Vector2I26F6(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingMul(
            this Vector2I26F6 x, I26F6 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingMul(
            this I26F6 x, Vector3I26F6 y
        ) => new Vector3I26F6(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingMul(
            this Vector3I26F6 x, I26F6 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingMul(
            this I26F6 x, Vector4I26F6 y
        ) => new Vector4I26F6(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingMul(
            this Vector4I26F6 x, I26F6 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingMul(
            this I27F5 x, Vector2I27F5 y
        ) => new Vector2I27F5(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingMul(
            this Vector2I27F5 x, I27F5 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingMul(
            this I27F5 x, Vector3I27F5 y
        ) => new Vector3I27F5(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingMul(
            this Vector3I27F5 x, I27F5 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingMul(
            this I27F5 x, Vector4I27F5 y
        ) => new Vector4I27F5(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingMul(
            this Vector4I27F5 x, I27F5 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingMul(
            this I28F4 x, Vector2I28F4 y
        ) => new Vector2I28F4(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingMul(
            this Vector2I28F4 x, I28F4 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingMul(
            this I28F4 x, Vector3I28F4 y
        ) => new Vector3I28F4(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingMul(
            this Vector3I28F4 x, I28F4 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingMul(
            this I28F4 x, Vector4I28F4 y
        ) => new Vector4I28F4(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingMul(
            this Vector4I28F4 x, I28F4 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingMul(
            this I29F3 x, Vector2I29F3 y
        ) => new Vector2I29F3(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingMul(
            this Vector2I29F3 x, I29F3 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingMul(
            this I29F3 x, Vector3I29F3 y
        ) => new Vector3I29F3(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingMul(
            this Vector3I29F3 x, I29F3 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingMul(
            this I29F3 x, Vector4I29F3 y
        ) => new Vector4I29F3(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingMul(
            this Vector4I29F3 x, I29F3 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingMul(
            this I30F2 x, Vector2I30F2 y
        ) => new Vector2I30F2(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingMul(
            this Vector2I30F2 x, I30F2 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingMul(
            this I30F2 x, Vector3I30F2 y
        ) => new Vector3I30F2(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingMul(
            this Vector3I30F2 x, I30F2 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingMul(
            this I30F2 x, Vector4I30F2 y
        ) => new Vector4I30F2(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingMul(
            this Vector4I30F2 x, I30F2 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingMul(
            this I31F1 x, Vector2I31F1 y
        ) => new Vector2I31F1(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingMul(
            this Vector2I31F1 x, I31F1 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingMul(
            this I31F1 x, Vector3I31F1 y
        ) => new Vector3I31F1(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingMul(
            this Vector3I31F1 x, I31F1 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingMul(
            this I31F1 x, Vector4I31F1 y
        ) => new Vector4I31F1(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingMul(
            this Vector4I31F1 x, I31F1 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingMul(
            this U2F30 x, Vector2U2F30 y
        ) => new Vector2U2F30(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingMul(
            this Vector2U2F30 x, U2F30 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingMul(
            this U2F30 x, Vector3U2F30 y
        ) => new Vector3U2F30(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingMul(
            this Vector3U2F30 x, U2F30 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingMul(
            this U2F30 x, Vector4U2F30 y
        ) => new Vector4U2F30(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingMul(
            this Vector4U2F30 x, U2F30 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingMul(
            this U3F29 x, Vector2U3F29 y
        ) => new Vector2U3F29(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingMul(
            this Vector2U3F29 x, U3F29 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingMul(
            this U3F29 x, Vector3U3F29 y
        ) => new Vector3U3F29(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingMul(
            this Vector3U3F29 x, U3F29 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingMul(
            this U3F29 x, Vector4U3F29 y
        ) => new Vector4U3F29(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingMul(
            this Vector4U3F29 x, U3F29 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingMul(
            this U4F28 x, Vector2U4F28 y
        ) => new Vector2U4F28(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingMul(
            this Vector2U4F28 x, U4F28 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingMul(
            this U4F28 x, Vector3U4F28 y
        ) => new Vector3U4F28(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingMul(
            this Vector3U4F28 x, U4F28 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingMul(
            this U4F28 x, Vector4U4F28 y
        ) => new Vector4U4F28(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingMul(
            this Vector4U4F28 x, U4F28 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingMul(
            this U5F27 x, Vector2U5F27 y
        ) => new Vector2U5F27(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingMul(
            this Vector2U5F27 x, U5F27 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingMul(
            this U5F27 x, Vector3U5F27 y
        ) => new Vector3U5F27(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingMul(
            this Vector3U5F27 x, U5F27 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingMul(
            this U5F27 x, Vector4U5F27 y
        ) => new Vector4U5F27(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingMul(
            this Vector4U5F27 x, U5F27 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingMul(
            this U6F26 x, Vector2U6F26 y
        ) => new Vector2U6F26(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingMul(
            this Vector2U6F26 x, U6F26 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingMul(
            this U6F26 x, Vector3U6F26 y
        ) => new Vector3U6F26(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingMul(
            this Vector3U6F26 x, U6F26 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingMul(
            this U6F26 x, Vector4U6F26 y
        ) => new Vector4U6F26(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingMul(
            this Vector4U6F26 x, U6F26 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingMul(
            this U7F25 x, Vector2U7F25 y
        ) => new Vector2U7F25(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingMul(
            this Vector2U7F25 x, U7F25 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingMul(
            this U7F25 x, Vector3U7F25 y
        ) => new Vector3U7F25(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingMul(
            this Vector3U7F25 x, U7F25 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingMul(
            this U7F25 x, Vector4U7F25 y
        ) => new Vector4U7F25(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingMul(
            this Vector4U7F25 x, U7F25 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingMul(
            this U8F24 x, Vector2U8F24 y
        ) => new Vector2U8F24(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingMul(
            this Vector2U8F24 x, U8F24 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingMul(
            this U8F24 x, Vector3U8F24 y
        ) => new Vector3U8F24(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingMul(
            this Vector3U8F24 x, U8F24 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingMul(
            this U8F24 x, Vector4U8F24 y
        ) => new Vector4U8F24(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingMul(
            this Vector4U8F24 x, U8F24 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingMul(
            this U9F23 x, Vector2U9F23 y
        ) => new Vector2U9F23(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingMul(
            this Vector2U9F23 x, U9F23 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingMul(
            this U9F23 x, Vector3U9F23 y
        ) => new Vector3U9F23(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingMul(
            this Vector3U9F23 x, U9F23 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingMul(
            this U9F23 x, Vector4U9F23 y
        ) => new Vector4U9F23(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingMul(
            this Vector4U9F23 x, U9F23 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingMul(
            this U10F22 x, Vector2U10F22 y
        ) => new Vector2U10F22(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingMul(
            this Vector2U10F22 x, U10F22 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingMul(
            this U10F22 x, Vector3U10F22 y
        ) => new Vector3U10F22(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingMul(
            this Vector3U10F22 x, U10F22 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingMul(
            this U10F22 x, Vector4U10F22 y
        ) => new Vector4U10F22(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingMul(
            this Vector4U10F22 x, U10F22 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingMul(
            this U11F21 x, Vector2U11F21 y
        ) => new Vector2U11F21(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingMul(
            this Vector2U11F21 x, U11F21 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingMul(
            this U11F21 x, Vector3U11F21 y
        ) => new Vector3U11F21(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingMul(
            this Vector3U11F21 x, U11F21 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingMul(
            this U11F21 x, Vector4U11F21 y
        ) => new Vector4U11F21(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingMul(
            this Vector4U11F21 x, U11F21 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingMul(
            this U12F20 x, Vector2U12F20 y
        ) => new Vector2U12F20(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingMul(
            this Vector2U12F20 x, U12F20 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingMul(
            this U12F20 x, Vector3U12F20 y
        ) => new Vector3U12F20(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingMul(
            this Vector3U12F20 x, U12F20 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingMul(
            this U12F20 x, Vector4U12F20 y
        ) => new Vector4U12F20(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingMul(
            this Vector4U12F20 x, U12F20 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingMul(
            this U13F19 x, Vector2U13F19 y
        ) => new Vector2U13F19(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingMul(
            this Vector2U13F19 x, U13F19 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingMul(
            this U13F19 x, Vector3U13F19 y
        ) => new Vector3U13F19(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingMul(
            this Vector3U13F19 x, U13F19 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingMul(
            this U13F19 x, Vector4U13F19 y
        ) => new Vector4U13F19(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingMul(
            this Vector4U13F19 x, U13F19 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingMul(
            this U14F18 x, Vector2U14F18 y
        ) => new Vector2U14F18(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingMul(
            this Vector2U14F18 x, U14F18 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingMul(
            this U14F18 x, Vector3U14F18 y
        ) => new Vector3U14F18(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingMul(
            this Vector3U14F18 x, U14F18 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingMul(
            this U14F18 x, Vector4U14F18 y
        ) => new Vector4U14F18(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingMul(
            this Vector4U14F18 x, U14F18 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingMul(
            this U15F17 x, Vector2U15F17 y
        ) => new Vector2U15F17(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingMul(
            this Vector2U15F17 x, U15F17 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingMul(
            this U15F17 x, Vector3U15F17 y
        ) => new Vector3U15F17(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingMul(
            this Vector3U15F17 x, U15F17 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingMul(
            this U15F17 x, Vector4U15F17 y
        ) => new Vector4U15F17(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingMul(
            this Vector4U15F17 x, U15F17 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingMul(
            this U16F16 x, Vector2U16F16 y
        ) => new Vector2U16F16(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingMul(
            this Vector2U16F16 x, U16F16 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingMul(
            this U16F16 x, Vector3U16F16 y
        ) => new Vector3U16F16(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingMul(
            this Vector3U16F16 x, U16F16 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingMul(
            this U16F16 x, Vector4U16F16 y
        ) => new Vector4U16F16(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingMul(
            this Vector4U16F16 x, U16F16 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingMul(
            this U17F15 x, Vector2U17F15 y
        ) => new Vector2U17F15(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingMul(
            this Vector2U17F15 x, U17F15 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingMul(
            this U17F15 x, Vector3U17F15 y
        ) => new Vector3U17F15(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingMul(
            this Vector3U17F15 x, U17F15 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingMul(
            this U17F15 x, Vector4U17F15 y
        ) => new Vector4U17F15(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingMul(
            this Vector4U17F15 x, U17F15 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingMul(
            this U18F14 x, Vector2U18F14 y
        ) => new Vector2U18F14(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingMul(
            this Vector2U18F14 x, U18F14 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingMul(
            this U18F14 x, Vector3U18F14 y
        ) => new Vector3U18F14(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingMul(
            this Vector3U18F14 x, U18F14 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingMul(
            this U18F14 x, Vector4U18F14 y
        ) => new Vector4U18F14(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingMul(
            this Vector4U18F14 x, U18F14 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingMul(
            this U19F13 x, Vector2U19F13 y
        ) => new Vector2U19F13(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingMul(
            this Vector2U19F13 x, U19F13 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingMul(
            this U19F13 x, Vector3U19F13 y
        ) => new Vector3U19F13(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingMul(
            this Vector3U19F13 x, U19F13 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingMul(
            this U19F13 x, Vector4U19F13 y
        ) => new Vector4U19F13(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingMul(
            this Vector4U19F13 x, U19F13 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingMul(
            this U20F12 x, Vector2U20F12 y
        ) => new Vector2U20F12(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingMul(
            this Vector2U20F12 x, U20F12 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingMul(
            this U20F12 x, Vector3U20F12 y
        ) => new Vector3U20F12(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingMul(
            this Vector3U20F12 x, U20F12 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingMul(
            this U20F12 x, Vector4U20F12 y
        ) => new Vector4U20F12(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingMul(
            this Vector4U20F12 x, U20F12 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingMul(
            this U21F11 x, Vector2U21F11 y
        ) => new Vector2U21F11(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingMul(
            this Vector2U21F11 x, U21F11 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingMul(
            this U21F11 x, Vector3U21F11 y
        ) => new Vector3U21F11(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingMul(
            this Vector3U21F11 x, U21F11 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingMul(
            this U21F11 x, Vector4U21F11 y
        ) => new Vector4U21F11(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingMul(
            this Vector4U21F11 x, U21F11 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingMul(
            this U22F10 x, Vector2U22F10 y
        ) => new Vector2U22F10(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingMul(
            this Vector2U22F10 x, U22F10 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingMul(
            this U22F10 x, Vector3U22F10 y
        ) => new Vector3U22F10(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingMul(
            this Vector3U22F10 x, U22F10 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingMul(
            this U22F10 x, Vector4U22F10 y
        ) => new Vector4U22F10(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingMul(
            this Vector4U22F10 x, U22F10 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingMul(
            this U23F9 x, Vector2U23F9 y
        ) => new Vector2U23F9(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingMul(
            this Vector2U23F9 x, U23F9 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingMul(
            this U23F9 x, Vector3U23F9 y
        ) => new Vector3U23F9(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingMul(
            this Vector3U23F9 x, U23F9 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingMul(
            this U23F9 x, Vector4U23F9 y
        ) => new Vector4U23F9(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingMul(
            this Vector4U23F9 x, U23F9 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingMul(
            this U24F8 x, Vector2U24F8 y
        ) => new Vector2U24F8(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingMul(
            this Vector2U24F8 x, U24F8 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingMul(
            this U24F8 x, Vector3U24F8 y
        ) => new Vector3U24F8(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingMul(
            this Vector3U24F8 x, U24F8 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingMul(
            this U24F8 x, Vector4U24F8 y
        ) => new Vector4U24F8(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingMul(
            this Vector4U24F8 x, U24F8 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingMul(
            this U25F7 x, Vector2U25F7 y
        ) => new Vector2U25F7(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingMul(
            this Vector2U25F7 x, U25F7 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingMul(
            this U25F7 x, Vector3U25F7 y
        ) => new Vector3U25F7(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingMul(
            this Vector3U25F7 x, U25F7 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingMul(
            this U25F7 x, Vector4U25F7 y
        ) => new Vector4U25F7(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingMul(
            this Vector4U25F7 x, U25F7 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingMul(
            this U26F6 x, Vector2U26F6 y
        ) => new Vector2U26F6(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingMul(
            this Vector2U26F6 x, U26F6 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingMul(
            this U26F6 x, Vector3U26F6 y
        ) => new Vector3U26F6(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingMul(
            this Vector3U26F6 x, U26F6 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingMul(
            this U26F6 x, Vector4U26F6 y
        ) => new Vector4U26F6(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingMul(
            this Vector4U26F6 x, U26F6 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingMul(
            this U27F5 x, Vector2U27F5 y
        ) => new Vector2U27F5(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingMul(
            this Vector2U27F5 x, U27F5 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingMul(
            this U27F5 x, Vector3U27F5 y
        ) => new Vector3U27F5(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingMul(
            this Vector3U27F5 x, U27F5 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingMul(
            this U27F5 x, Vector4U27F5 y
        ) => new Vector4U27F5(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingMul(
            this Vector4U27F5 x, U27F5 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingMul(
            this U28F4 x, Vector2U28F4 y
        ) => new Vector2U28F4(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingMul(
            this Vector2U28F4 x, U28F4 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingMul(
            this U28F4 x, Vector3U28F4 y
        ) => new Vector3U28F4(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingMul(
            this Vector3U28F4 x, U28F4 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingMul(
            this U28F4 x, Vector4U28F4 y
        ) => new Vector4U28F4(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingMul(
            this Vector4U28F4 x, U28F4 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingMul(
            this U29F3 x, Vector2U29F3 y
        ) => new Vector2U29F3(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingMul(
            this Vector2U29F3 x, U29F3 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingMul(
            this U29F3 x, Vector3U29F3 y
        ) => new Vector3U29F3(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingMul(
            this Vector3U29F3 x, U29F3 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingMul(
            this U29F3 x, Vector4U29F3 y
        ) => new Vector4U29F3(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingMul(
            this Vector4U29F3 x, U29F3 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingMul(
            this U30F2 x, Vector2U30F2 y
        ) => new Vector2U30F2(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingMul(
            this Vector2U30F2 x, U30F2 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingMul(
            this U30F2 x, Vector3U30F2 y
        ) => new Vector3U30F2(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingMul(
            this Vector3U30F2 x, U30F2 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingMul(
            this U30F2 x, Vector4U30F2 y
        ) => new Vector4U30F2(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingMul(
            this Vector4U30F2 x, U30F2 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingMul(
            this U31F1 x, Vector2U31F1 y
        ) => new Vector2U31F1(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingMul(
            this Vector2U31F1 x, U31F1 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingMul(
            this U31F1 x, Vector3U31F1 y
        ) => new Vector3U31F1(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingMul(
            this Vector3U31F1 x, U31F1 y
        ) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingMul(
            this U31F1 x, Vector4U31F1 y
        ) => new Vector4U31F1(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y),
            x.SaturatingMul(y.Z),
            x.SaturatingMul(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingMul(
            this Vector4U31F1 x, U31F1 y
        ) => y.SaturatingMul(x);

    }
}
