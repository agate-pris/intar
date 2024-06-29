using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Half(int x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Half(uint x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Half(long x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Half(ulong x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I2F30 Half(this I2F30 x) => I2F30.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I3F29 Half(this I3F29 x) => I3F29.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I4F28 Half(this I4F28 x) => I4F28.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I5F27 Half(this I5F27 x) => I5F27.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I6F26 Half(this I6F26 x) => I6F26.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I7F25 Half(this I7F25 x) => I7F25.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I8F24 Half(this I8F24 x) => I8F24.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I9F23 Half(this I9F23 x) => I9F23.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I10F22 Half(this I10F22 x) => I10F22.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I11F21 Half(this I11F21 x) => I11F21.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I12F20 Half(this I12F20 x) => I12F20.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I13F19 Half(this I13F19 x) => I13F19.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I14F18 Half(this I14F18 x) => I14F18.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I15F17 Half(this I15F17 x) => I15F17.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I16F16 Half(this I16F16 x) => I16F16.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I17F15 Half(this I17F15 x) => I17F15.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I18F14 Half(this I18F14 x) => I18F14.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I19F13 Half(this I19F13 x) => I19F13.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I20F12 Half(this I20F12 x) => I20F12.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I21F11 Half(this I21F11 x) => I21F11.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I22F10 Half(this I22F10 x) => I22F10.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I23F9 Half(this I23F9 x) => I23F9.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I24F8 Half(this I24F8 x) => I24F8.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I25F7 Half(this I25F7 x) => I25F7.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I26F6 Half(this I26F6 x) => I26F6.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I27F5 Half(this I27F5 x) => I27F5.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I28F4 Half(this I28F4 x) => I28F4.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I29F3 Half(this I29F3 x) => I29F3.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I30F2 Half(this I30F2 x) => I30F2.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I31F1 Half(this I31F1 x) => I31F1.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U2F30 Half(this U2F30 x) => U2F30.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U3F29 Half(this U3F29 x) => U3F29.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U4F28 Half(this U4F28 x) => U4F28.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U5F27 Half(this U5F27 x) => U5F27.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U6F26 Half(this U6F26 x) => U6F26.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U7F25 Half(this U7F25 x) => U7F25.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U8F24 Half(this U8F24 x) => U8F24.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U9F23 Half(this U9F23 x) => U9F23.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U10F22 Half(this U10F22 x) => U10F22.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U11F21 Half(this U11F21 x) => U11F21.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U12F20 Half(this U12F20 x) => U12F20.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U13F19 Half(this U13F19 x) => U13F19.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U14F18 Half(this U14F18 x) => U14F18.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U15F17 Half(this U15F17 x) => U15F17.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U16F16 Half(this U16F16 x) => U16F16.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U17F15 Half(this U17F15 x) => U17F15.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U18F14 Half(this U18F14 x) => U18F14.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U19F13 Half(this U19F13 x) => U19F13.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U20F12 Half(this U20F12 x) => U20F12.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U21F11 Half(this U21F11 x) => U21F11.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U22F10 Half(this U22F10 x) => U22F10.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U23F9 Half(this U23F9 x) => U23F9.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U24F8 Half(this U24F8 x) => U24F8.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U25F7 Half(this U25F7 x) => U25F7.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U26F6 Half(this U26F6 x) => U26F6.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U27F5 Half(this U27F5 x) => U27F5.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U28F4 Half(this U28F4 x) => U28F4.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U29F3 Half(this U29F3 x) => U29F3.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U30F2 Half(this U30F2 x) => U30F2.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U31F1 Half(this U31F1 x) => U31F1.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I2F62 Half(this I2F62 x) => I2F62.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I3F61 Half(this I3F61 x) => I3F61.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I4F60 Half(this I4F60 x) => I4F60.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I5F59 Half(this I5F59 x) => I5F59.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I6F58 Half(this I6F58 x) => I6F58.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I7F57 Half(this I7F57 x) => I7F57.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I8F56 Half(this I8F56 x) => I8F56.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I9F55 Half(this I9F55 x) => I9F55.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I10F54 Half(this I10F54 x) => I10F54.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I11F53 Half(this I11F53 x) => I11F53.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I12F52 Half(this I12F52 x) => I12F52.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I13F51 Half(this I13F51 x) => I13F51.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I14F50 Half(this I14F50 x) => I14F50.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I15F49 Half(this I15F49 x) => I15F49.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I16F48 Half(this I16F48 x) => I16F48.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I17F47 Half(this I17F47 x) => I17F47.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I18F46 Half(this I18F46 x) => I18F46.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I19F45 Half(this I19F45 x) => I19F45.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I20F44 Half(this I20F44 x) => I20F44.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I21F43 Half(this I21F43 x) => I21F43.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I22F42 Half(this I22F42 x) => I22F42.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I23F41 Half(this I23F41 x) => I23F41.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I24F40 Half(this I24F40 x) => I24F40.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I25F39 Half(this I25F39 x) => I25F39.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I26F38 Half(this I26F38 x) => I26F38.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I27F37 Half(this I27F37 x) => I27F37.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I28F36 Half(this I28F36 x) => I28F36.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I29F35 Half(this I29F35 x) => I29F35.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I30F34 Half(this I30F34 x) => I30F34.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I31F33 Half(this I31F33 x) => I31F33.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U2F62 Half(this U2F62 x) => U2F62.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U3F61 Half(this U3F61 x) => U3F61.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U4F60 Half(this U4F60 x) => U4F60.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U5F59 Half(this U5F59 x) => U5F59.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U6F58 Half(this U6F58 x) => U6F58.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U7F57 Half(this U7F57 x) => U7F57.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U8F56 Half(this U8F56 x) => U8F56.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U9F55 Half(this U9F55 x) => U9F55.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U10F54 Half(this U10F54 x) => U10F54.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U11F53 Half(this U11F53 x) => U11F53.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U12F52 Half(this U12F52 x) => U12F52.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U13F51 Half(this U13F51 x) => U13F51.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U14F50 Half(this U14F50 x) => U14F50.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U15F49 Half(this U15F49 x) => U15F49.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U16F48 Half(this U16F48 x) => U16F48.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U17F47 Half(this U17F47 x) => U17F47.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U18F46 Half(this U18F46 x) => U18F46.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U19F45 Half(this U19F45 x) => U19F45.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U20F44 Half(this U20F44 x) => U20F44.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U21F43 Half(this U21F43 x) => U21F43.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U22F42 Half(this U22F42 x) => U22F42.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U23F41 Half(this U23F41 x) => U23F41.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U24F40 Half(this U24F40 x) => U24F40.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U25F39 Half(this U25F39 x) => U25F39.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U26F38 Half(this U26F38 x) => U26F38.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U27F37 Half(this U27F37 x) => U27F37.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U28F36 Half(this U28F36 x) => U28F36.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U29F35 Half(this U29F35 x) => U29F35.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U30F34 Half(this U30F34 x) => U30F34.FromBits(Half(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U31F33 Half(this U31F33 x) => U31F33.FromBits(Half(x.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 Half(this Vector2I2F30 x) => new Vector2I2F30(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 Half(this Vector2I3F29 x) => new Vector2I3F29(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 Half(this Vector2I4F28 x) => new Vector2I4F28(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 Half(this Vector2I5F27 x) => new Vector2I5F27(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 Half(this Vector2I6F26 x) => new Vector2I6F26(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 Half(this Vector2I7F25 x) => new Vector2I7F25(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 Half(this Vector2I8F24 x) => new Vector2I8F24(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 Half(this Vector2I9F23 x) => new Vector2I9F23(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 Half(this Vector2I10F22 x) => new Vector2I10F22(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 Half(this Vector2I11F21 x) => new Vector2I11F21(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 Half(this Vector2I12F20 x) => new Vector2I12F20(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 Half(this Vector2I13F19 x) => new Vector2I13F19(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 Half(this Vector2I14F18 x) => new Vector2I14F18(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 Half(this Vector2I15F17 x) => new Vector2I15F17(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 Half(this Vector2I16F16 x) => new Vector2I16F16(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 Half(this Vector2I17F15 x) => new Vector2I17F15(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 Half(this Vector2I18F14 x) => new Vector2I18F14(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 Half(this Vector2I19F13 x) => new Vector2I19F13(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 Half(this Vector2I20F12 x) => new Vector2I20F12(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 Half(this Vector2I21F11 x) => new Vector2I21F11(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 Half(this Vector2I22F10 x) => new Vector2I22F10(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 Half(this Vector2I23F9 x) => new Vector2I23F9(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 Half(this Vector2I24F8 x) => new Vector2I24F8(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 Half(this Vector2I25F7 x) => new Vector2I25F7(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 Half(this Vector2I26F6 x) => new Vector2I26F6(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 Half(this Vector2I27F5 x) => new Vector2I27F5(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 Half(this Vector2I28F4 x) => new Vector2I28F4(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 Half(this Vector2I29F3 x) => new Vector2I29F3(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 Half(this Vector2I30F2 x) => new Vector2I30F2(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 Half(this Vector2I31F1 x) => new Vector2I31F1(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 Half(this Vector2U2F30 x) => new Vector2U2F30(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 Half(this Vector2U3F29 x) => new Vector2U3F29(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 Half(this Vector2U4F28 x) => new Vector2U4F28(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 Half(this Vector2U5F27 x) => new Vector2U5F27(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 Half(this Vector2U6F26 x) => new Vector2U6F26(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 Half(this Vector2U7F25 x) => new Vector2U7F25(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 Half(this Vector2U8F24 x) => new Vector2U8F24(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 Half(this Vector2U9F23 x) => new Vector2U9F23(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 Half(this Vector2U10F22 x) => new Vector2U10F22(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 Half(this Vector2U11F21 x) => new Vector2U11F21(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 Half(this Vector2U12F20 x) => new Vector2U12F20(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 Half(this Vector2U13F19 x) => new Vector2U13F19(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 Half(this Vector2U14F18 x) => new Vector2U14F18(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 Half(this Vector2U15F17 x) => new Vector2U15F17(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 Half(this Vector2U16F16 x) => new Vector2U16F16(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 Half(this Vector2U17F15 x) => new Vector2U17F15(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 Half(this Vector2U18F14 x) => new Vector2U18F14(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 Half(this Vector2U19F13 x) => new Vector2U19F13(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 Half(this Vector2U20F12 x) => new Vector2U20F12(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 Half(this Vector2U21F11 x) => new Vector2U21F11(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 Half(this Vector2U22F10 x) => new Vector2U22F10(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 Half(this Vector2U23F9 x) => new Vector2U23F9(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 Half(this Vector2U24F8 x) => new Vector2U24F8(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 Half(this Vector2U25F7 x) => new Vector2U25F7(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 Half(this Vector2U26F6 x) => new Vector2U26F6(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 Half(this Vector2U27F5 x) => new Vector2U27F5(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 Half(this Vector2U28F4 x) => new Vector2U28F4(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 Half(this Vector2U29F3 x) => new Vector2U29F3(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 Half(this Vector2U30F2 x) => new Vector2U30F2(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 Half(this Vector2U31F1 x) => new Vector2U31F1(
            x.X.Half(),
            x.Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 Half(this Vector3I2F30 x) => new Vector3I2F30(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 Half(this Vector3I3F29 x) => new Vector3I3F29(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 Half(this Vector3I4F28 x) => new Vector3I4F28(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 Half(this Vector3I5F27 x) => new Vector3I5F27(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 Half(this Vector3I6F26 x) => new Vector3I6F26(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 Half(this Vector3I7F25 x) => new Vector3I7F25(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 Half(this Vector3I8F24 x) => new Vector3I8F24(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 Half(this Vector3I9F23 x) => new Vector3I9F23(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 Half(this Vector3I10F22 x) => new Vector3I10F22(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 Half(this Vector3I11F21 x) => new Vector3I11F21(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 Half(this Vector3I12F20 x) => new Vector3I12F20(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 Half(this Vector3I13F19 x) => new Vector3I13F19(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 Half(this Vector3I14F18 x) => new Vector3I14F18(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 Half(this Vector3I15F17 x) => new Vector3I15F17(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 Half(this Vector3I16F16 x) => new Vector3I16F16(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 Half(this Vector3I17F15 x) => new Vector3I17F15(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 Half(this Vector3I18F14 x) => new Vector3I18F14(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 Half(this Vector3I19F13 x) => new Vector3I19F13(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 Half(this Vector3I20F12 x) => new Vector3I20F12(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 Half(this Vector3I21F11 x) => new Vector3I21F11(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 Half(this Vector3I22F10 x) => new Vector3I22F10(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 Half(this Vector3I23F9 x) => new Vector3I23F9(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 Half(this Vector3I24F8 x) => new Vector3I24F8(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 Half(this Vector3I25F7 x) => new Vector3I25F7(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 Half(this Vector3I26F6 x) => new Vector3I26F6(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 Half(this Vector3I27F5 x) => new Vector3I27F5(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 Half(this Vector3I28F4 x) => new Vector3I28F4(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 Half(this Vector3I29F3 x) => new Vector3I29F3(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 Half(this Vector3I30F2 x) => new Vector3I30F2(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 Half(this Vector3I31F1 x) => new Vector3I31F1(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 Half(this Vector3U2F30 x) => new Vector3U2F30(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 Half(this Vector3U3F29 x) => new Vector3U3F29(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 Half(this Vector3U4F28 x) => new Vector3U4F28(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 Half(this Vector3U5F27 x) => new Vector3U5F27(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 Half(this Vector3U6F26 x) => new Vector3U6F26(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 Half(this Vector3U7F25 x) => new Vector3U7F25(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 Half(this Vector3U8F24 x) => new Vector3U8F24(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 Half(this Vector3U9F23 x) => new Vector3U9F23(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 Half(this Vector3U10F22 x) => new Vector3U10F22(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 Half(this Vector3U11F21 x) => new Vector3U11F21(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 Half(this Vector3U12F20 x) => new Vector3U12F20(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 Half(this Vector3U13F19 x) => new Vector3U13F19(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 Half(this Vector3U14F18 x) => new Vector3U14F18(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 Half(this Vector3U15F17 x) => new Vector3U15F17(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 Half(this Vector3U16F16 x) => new Vector3U16F16(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 Half(this Vector3U17F15 x) => new Vector3U17F15(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 Half(this Vector3U18F14 x) => new Vector3U18F14(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 Half(this Vector3U19F13 x) => new Vector3U19F13(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 Half(this Vector3U20F12 x) => new Vector3U20F12(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 Half(this Vector3U21F11 x) => new Vector3U21F11(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 Half(this Vector3U22F10 x) => new Vector3U22F10(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 Half(this Vector3U23F9 x) => new Vector3U23F9(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 Half(this Vector3U24F8 x) => new Vector3U24F8(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 Half(this Vector3U25F7 x) => new Vector3U25F7(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 Half(this Vector3U26F6 x) => new Vector3U26F6(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 Half(this Vector3U27F5 x) => new Vector3U27F5(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 Half(this Vector3U28F4 x) => new Vector3U28F4(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 Half(this Vector3U29F3 x) => new Vector3U29F3(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 Half(this Vector3U30F2 x) => new Vector3U30F2(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 Half(this Vector3U31F1 x) => new Vector3U31F1(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 Half(this Vector4I2F30 x) => new Vector4I2F30(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 Half(this Vector4I3F29 x) => new Vector4I3F29(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 Half(this Vector4I4F28 x) => new Vector4I4F28(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 Half(this Vector4I5F27 x) => new Vector4I5F27(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 Half(this Vector4I6F26 x) => new Vector4I6F26(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 Half(this Vector4I7F25 x) => new Vector4I7F25(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 Half(this Vector4I8F24 x) => new Vector4I8F24(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 Half(this Vector4I9F23 x) => new Vector4I9F23(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 Half(this Vector4I10F22 x) => new Vector4I10F22(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 Half(this Vector4I11F21 x) => new Vector4I11F21(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 Half(this Vector4I12F20 x) => new Vector4I12F20(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 Half(this Vector4I13F19 x) => new Vector4I13F19(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 Half(this Vector4I14F18 x) => new Vector4I14F18(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 Half(this Vector4I15F17 x) => new Vector4I15F17(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 Half(this Vector4I16F16 x) => new Vector4I16F16(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 Half(this Vector4I17F15 x) => new Vector4I17F15(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 Half(this Vector4I18F14 x) => new Vector4I18F14(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 Half(this Vector4I19F13 x) => new Vector4I19F13(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 Half(this Vector4I20F12 x) => new Vector4I20F12(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 Half(this Vector4I21F11 x) => new Vector4I21F11(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 Half(this Vector4I22F10 x) => new Vector4I22F10(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 Half(this Vector4I23F9 x) => new Vector4I23F9(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 Half(this Vector4I24F8 x) => new Vector4I24F8(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 Half(this Vector4I25F7 x) => new Vector4I25F7(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 Half(this Vector4I26F6 x) => new Vector4I26F6(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 Half(this Vector4I27F5 x) => new Vector4I27F5(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 Half(this Vector4I28F4 x) => new Vector4I28F4(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 Half(this Vector4I29F3 x) => new Vector4I29F3(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 Half(this Vector4I30F2 x) => new Vector4I30F2(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 Half(this Vector4I31F1 x) => new Vector4I31F1(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 Half(this Vector4U2F30 x) => new Vector4U2F30(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 Half(this Vector4U3F29 x) => new Vector4U3F29(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 Half(this Vector4U4F28 x) => new Vector4U4F28(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 Half(this Vector4U5F27 x) => new Vector4U5F27(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 Half(this Vector4U6F26 x) => new Vector4U6F26(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 Half(this Vector4U7F25 x) => new Vector4U7F25(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 Half(this Vector4U8F24 x) => new Vector4U8F24(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 Half(this Vector4U9F23 x) => new Vector4U9F23(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 Half(this Vector4U10F22 x) => new Vector4U10F22(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 Half(this Vector4U11F21 x) => new Vector4U11F21(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 Half(this Vector4U12F20 x) => new Vector4U12F20(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 Half(this Vector4U13F19 x) => new Vector4U13F19(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 Half(this Vector4U14F18 x) => new Vector4U14F18(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 Half(this Vector4U15F17 x) => new Vector4U15F17(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 Half(this Vector4U16F16 x) => new Vector4U16F16(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 Half(this Vector4U17F15 x) => new Vector4U17F15(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 Half(this Vector4U18F14 x) => new Vector4U18F14(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 Half(this Vector4U19F13 x) => new Vector4U19F13(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 Half(this Vector4U20F12 x) => new Vector4U20F12(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 Half(this Vector4U21F11 x) => new Vector4U21F11(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 Half(this Vector4U22F10 x) => new Vector4U22F10(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 Half(this Vector4U23F9 x) => new Vector4U23F9(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 Half(this Vector4U24F8 x) => new Vector4U24F8(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 Half(this Vector4U25F7 x) => new Vector4U25F7(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 Half(this Vector4U26F6 x) => new Vector4U26F6(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 Half(this Vector4U27F5 x) => new Vector4U27F5(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 Half(this Vector4U28F4 x) => new Vector4U28F4(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 Half(this Vector4U29F3 x) => new Vector4U29F3(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 Half(this Vector4U30F2 x) => new Vector4U30F2(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 Half(this Vector4U31F1 x) => new Vector4U31F1(
            x.X.Half(),
            x.Y.Half(),
            x.Z.Half(),
            x.W.Half());

    }
}
