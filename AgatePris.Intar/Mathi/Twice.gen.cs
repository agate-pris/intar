using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Twice(int x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Twice(uint x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Twice(long x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Twice(ulong x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I2F30 Twice(this I2F30 x) => I2F30.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I3F29 Twice(this I3F29 x) => I3F29.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I4F28 Twice(this I4F28 x) => I4F28.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I5F27 Twice(this I5F27 x) => I5F27.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I6F26 Twice(this I6F26 x) => I6F26.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I7F25 Twice(this I7F25 x) => I7F25.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I8F24 Twice(this I8F24 x) => I8F24.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I9F23 Twice(this I9F23 x) => I9F23.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I10F22 Twice(this I10F22 x) => I10F22.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I11F21 Twice(this I11F21 x) => I11F21.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I12F20 Twice(this I12F20 x) => I12F20.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I13F19 Twice(this I13F19 x) => I13F19.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I14F18 Twice(this I14F18 x) => I14F18.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I15F17 Twice(this I15F17 x) => I15F17.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I16F16 Twice(this I16F16 x) => I16F16.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I17F15 Twice(this I17F15 x) => I17F15.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I18F14 Twice(this I18F14 x) => I18F14.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I19F13 Twice(this I19F13 x) => I19F13.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I20F12 Twice(this I20F12 x) => I20F12.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I21F11 Twice(this I21F11 x) => I21F11.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I22F10 Twice(this I22F10 x) => I22F10.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I23F9 Twice(this I23F9 x) => I23F9.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I24F8 Twice(this I24F8 x) => I24F8.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I25F7 Twice(this I25F7 x) => I25F7.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I26F6 Twice(this I26F6 x) => I26F6.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I27F5 Twice(this I27F5 x) => I27F5.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I28F4 Twice(this I28F4 x) => I28F4.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I29F3 Twice(this I29F3 x) => I29F3.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I30F2 Twice(this I30F2 x) => I30F2.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I31F1 Twice(this I31F1 x) => I31F1.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U2F30 Twice(this U2F30 x) => U2F30.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U3F29 Twice(this U3F29 x) => U3F29.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U4F28 Twice(this U4F28 x) => U4F28.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U5F27 Twice(this U5F27 x) => U5F27.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U6F26 Twice(this U6F26 x) => U6F26.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U7F25 Twice(this U7F25 x) => U7F25.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U8F24 Twice(this U8F24 x) => U8F24.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U9F23 Twice(this U9F23 x) => U9F23.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U10F22 Twice(this U10F22 x) => U10F22.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U11F21 Twice(this U11F21 x) => U11F21.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U12F20 Twice(this U12F20 x) => U12F20.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U13F19 Twice(this U13F19 x) => U13F19.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U14F18 Twice(this U14F18 x) => U14F18.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U15F17 Twice(this U15F17 x) => U15F17.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U16F16 Twice(this U16F16 x) => U16F16.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U17F15 Twice(this U17F15 x) => U17F15.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U18F14 Twice(this U18F14 x) => U18F14.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U19F13 Twice(this U19F13 x) => U19F13.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U20F12 Twice(this U20F12 x) => U20F12.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U21F11 Twice(this U21F11 x) => U21F11.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U22F10 Twice(this U22F10 x) => U22F10.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U23F9 Twice(this U23F9 x) => U23F9.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U24F8 Twice(this U24F8 x) => U24F8.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U25F7 Twice(this U25F7 x) => U25F7.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U26F6 Twice(this U26F6 x) => U26F6.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U27F5 Twice(this U27F5 x) => U27F5.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U28F4 Twice(this U28F4 x) => U28F4.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U29F3 Twice(this U29F3 x) => U29F3.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U30F2 Twice(this U30F2 x) => U30F2.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U31F1 Twice(this U31F1 x) => U31F1.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I2F62 Twice(this I2F62 x) => I2F62.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I3F61 Twice(this I3F61 x) => I3F61.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I4F60 Twice(this I4F60 x) => I4F60.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I5F59 Twice(this I5F59 x) => I5F59.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I6F58 Twice(this I6F58 x) => I6F58.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I7F57 Twice(this I7F57 x) => I7F57.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I8F56 Twice(this I8F56 x) => I8F56.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I9F55 Twice(this I9F55 x) => I9F55.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I10F54 Twice(this I10F54 x) => I10F54.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I11F53 Twice(this I11F53 x) => I11F53.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I12F52 Twice(this I12F52 x) => I12F52.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I13F51 Twice(this I13F51 x) => I13F51.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I14F50 Twice(this I14F50 x) => I14F50.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I15F49 Twice(this I15F49 x) => I15F49.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I16F48 Twice(this I16F48 x) => I16F48.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I17F47 Twice(this I17F47 x) => I17F47.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I18F46 Twice(this I18F46 x) => I18F46.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I19F45 Twice(this I19F45 x) => I19F45.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I20F44 Twice(this I20F44 x) => I20F44.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I21F43 Twice(this I21F43 x) => I21F43.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I22F42 Twice(this I22F42 x) => I22F42.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I23F41 Twice(this I23F41 x) => I23F41.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I24F40 Twice(this I24F40 x) => I24F40.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I25F39 Twice(this I25F39 x) => I25F39.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I26F38 Twice(this I26F38 x) => I26F38.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I27F37 Twice(this I27F37 x) => I27F37.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I28F36 Twice(this I28F36 x) => I28F36.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I29F35 Twice(this I29F35 x) => I29F35.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I30F34 Twice(this I30F34 x) => I30F34.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I31F33 Twice(this I31F33 x) => I31F33.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U2F62 Twice(this U2F62 x) => U2F62.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U3F61 Twice(this U3F61 x) => U3F61.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U4F60 Twice(this U4F60 x) => U4F60.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U5F59 Twice(this U5F59 x) => U5F59.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U6F58 Twice(this U6F58 x) => U6F58.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U7F57 Twice(this U7F57 x) => U7F57.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U8F56 Twice(this U8F56 x) => U8F56.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U9F55 Twice(this U9F55 x) => U9F55.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U10F54 Twice(this U10F54 x) => U10F54.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U11F53 Twice(this U11F53 x) => U11F53.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U12F52 Twice(this U12F52 x) => U12F52.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U13F51 Twice(this U13F51 x) => U13F51.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U14F50 Twice(this U14F50 x) => U14F50.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U15F49 Twice(this U15F49 x) => U15F49.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U16F48 Twice(this U16F48 x) => U16F48.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U17F47 Twice(this U17F47 x) => U17F47.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U18F46 Twice(this U18F46 x) => U18F46.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U19F45 Twice(this U19F45 x) => U19F45.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U20F44 Twice(this U20F44 x) => U20F44.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U21F43 Twice(this U21F43 x) => U21F43.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U22F42 Twice(this U22F42 x) => U22F42.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U23F41 Twice(this U23F41 x) => U23F41.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U24F40 Twice(this U24F40 x) => U24F40.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U25F39 Twice(this U25F39 x) => U25F39.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U26F38 Twice(this U26F38 x) => U26F38.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U27F37 Twice(this U27F37 x) => U27F37.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U28F36 Twice(this U28F36 x) => U28F36.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U29F35 Twice(this U29F35 x) => U29F35.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U30F34 Twice(this U30F34 x) => U30F34.FromBits(Twice(x.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U31F33 Twice(this U31F33 x) => U31F33.FromBits(Twice(x.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 Twice(this Vector2I2F30 x) => new Vector2I2F30(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 Twice(this Vector2I3F29 x) => new Vector2I3F29(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 Twice(this Vector2I4F28 x) => new Vector2I4F28(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 Twice(this Vector2I5F27 x) => new Vector2I5F27(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 Twice(this Vector2I6F26 x) => new Vector2I6F26(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 Twice(this Vector2I7F25 x) => new Vector2I7F25(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 Twice(this Vector2I8F24 x) => new Vector2I8F24(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 Twice(this Vector2I9F23 x) => new Vector2I9F23(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 Twice(this Vector2I10F22 x) => new Vector2I10F22(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 Twice(this Vector2I11F21 x) => new Vector2I11F21(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 Twice(this Vector2I12F20 x) => new Vector2I12F20(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 Twice(this Vector2I13F19 x) => new Vector2I13F19(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 Twice(this Vector2I14F18 x) => new Vector2I14F18(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 Twice(this Vector2I15F17 x) => new Vector2I15F17(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 Twice(this Vector2I16F16 x) => new Vector2I16F16(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 Twice(this Vector2I17F15 x) => new Vector2I17F15(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 Twice(this Vector2I18F14 x) => new Vector2I18F14(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 Twice(this Vector2I19F13 x) => new Vector2I19F13(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 Twice(this Vector2I20F12 x) => new Vector2I20F12(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 Twice(this Vector2I21F11 x) => new Vector2I21F11(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 Twice(this Vector2I22F10 x) => new Vector2I22F10(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 Twice(this Vector2I23F9 x) => new Vector2I23F9(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 Twice(this Vector2I24F8 x) => new Vector2I24F8(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 Twice(this Vector2I25F7 x) => new Vector2I25F7(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 Twice(this Vector2I26F6 x) => new Vector2I26F6(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 Twice(this Vector2I27F5 x) => new Vector2I27F5(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 Twice(this Vector2I28F4 x) => new Vector2I28F4(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 Twice(this Vector2I29F3 x) => new Vector2I29F3(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 Twice(this Vector2I30F2 x) => new Vector2I30F2(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 Twice(this Vector2I31F1 x) => new Vector2I31F1(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 Twice(this Vector2U2F30 x) => new Vector2U2F30(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 Twice(this Vector2U3F29 x) => new Vector2U3F29(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 Twice(this Vector2U4F28 x) => new Vector2U4F28(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 Twice(this Vector2U5F27 x) => new Vector2U5F27(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 Twice(this Vector2U6F26 x) => new Vector2U6F26(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 Twice(this Vector2U7F25 x) => new Vector2U7F25(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 Twice(this Vector2U8F24 x) => new Vector2U8F24(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 Twice(this Vector2U9F23 x) => new Vector2U9F23(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 Twice(this Vector2U10F22 x) => new Vector2U10F22(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 Twice(this Vector2U11F21 x) => new Vector2U11F21(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 Twice(this Vector2U12F20 x) => new Vector2U12F20(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 Twice(this Vector2U13F19 x) => new Vector2U13F19(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 Twice(this Vector2U14F18 x) => new Vector2U14F18(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 Twice(this Vector2U15F17 x) => new Vector2U15F17(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 Twice(this Vector2U16F16 x) => new Vector2U16F16(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 Twice(this Vector2U17F15 x) => new Vector2U17F15(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 Twice(this Vector2U18F14 x) => new Vector2U18F14(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 Twice(this Vector2U19F13 x) => new Vector2U19F13(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 Twice(this Vector2U20F12 x) => new Vector2U20F12(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 Twice(this Vector2U21F11 x) => new Vector2U21F11(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 Twice(this Vector2U22F10 x) => new Vector2U22F10(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 Twice(this Vector2U23F9 x) => new Vector2U23F9(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 Twice(this Vector2U24F8 x) => new Vector2U24F8(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 Twice(this Vector2U25F7 x) => new Vector2U25F7(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 Twice(this Vector2U26F6 x) => new Vector2U26F6(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 Twice(this Vector2U27F5 x) => new Vector2U27F5(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 Twice(this Vector2U28F4 x) => new Vector2U28F4(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 Twice(this Vector2U29F3 x) => new Vector2U29F3(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 Twice(this Vector2U30F2 x) => new Vector2U30F2(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 Twice(this Vector2U31F1 x) => new Vector2U31F1(
            x.X.Twice(),
            x.Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 Twice(this Vector3I2F30 x) => new Vector3I2F30(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 Twice(this Vector3I3F29 x) => new Vector3I3F29(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 Twice(this Vector3I4F28 x) => new Vector3I4F28(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 Twice(this Vector3I5F27 x) => new Vector3I5F27(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 Twice(this Vector3I6F26 x) => new Vector3I6F26(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 Twice(this Vector3I7F25 x) => new Vector3I7F25(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 Twice(this Vector3I8F24 x) => new Vector3I8F24(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 Twice(this Vector3I9F23 x) => new Vector3I9F23(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 Twice(this Vector3I10F22 x) => new Vector3I10F22(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 Twice(this Vector3I11F21 x) => new Vector3I11F21(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 Twice(this Vector3I12F20 x) => new Vector3I12F20(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 Twice(this Vector3I13F19 x) => new Vector3I13F19(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 Twice(this Vector3I14F18 x) => new Vector3I14F18(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 Twice(this Vector3I15F17 x) => new Vector3I15F17(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 Twice(this Vector3I16F16 x) => new Vector3I16F16(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 Twice(this Vector3I17F15 x) => new Vector3I17F15(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 Twice(this Vector3I18F14 x) => new Vector3I18F14(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 Twice(this Vector3I19F13 x) => new Vector3I19F13(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 Twice(this Vector3I20F12 x) => new Vector3I20F12(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 Twice(this Vector3I21F11 x) => new Vector3I21F11(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 Twice(this Vector3I22F10 x) => new Vector3I22F10(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 Twice(this Vector3I23F9 x) => new Vector3I23F9(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 Twice(this Vector3I24F8 x) => new Vector3I24F8(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 Twice(this Vector3I25F7 x) => new Vector3I25F7(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 Twice(this Vector3I26F6 x) => new Vector3I26F6(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 Twice(this Vector3I27F5 x) => new Vector3I27F5(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 Twice(this Vector3I28F4 x) => new Vector3I28F4(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 Twice(this Vector3I29F3 x) => new Vector3I29F3(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 Twice(this Vector3I30F2 x) => new Vector3I30F2(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 Twice(this Vector3I31F1 x) => new Vector3I31F1(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 Twice(this Vector3U2F30 x) => new Vector3U2F30(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 Twice(this Vector3U3F29 x) => new Vector3U3F29(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 Twice(this Vector3U4F28 x) => new Vector3U4F28(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 Twice(this Vector3U5F27 x) => new Vector3U5F27(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 Twice(this Vector3U6F26 x) => new Vector3U6F26(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 Twice(this Vector3U7F25 x) => new Vector3U7F25(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 Twice(this Vector3U8F24 x) => new Vector3U8F24(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 Twice(this Vector3U9F23 x) => new Vector3U9F23(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 Twice(this Vector3U10F22 x) => new Vector3U10F22(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 Twice(this Vector3U11F21 x) => new Vector3U11F21(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 Twice(this Vector3U12F20 x) => new Vector3U12F20(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 Twice(this Vector3U13F19 x) => new Vector3U13F19(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 Twice(this Vector3U14F18 x) => new Vector3U14F18(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 Twice(this Vector3U15F17 x) => new Vector3U15F17(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 Twice(this Vector3U16F16 x) => new Vector3U16F16(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 Twice(this Vector3U17F15 x) => new Vector3U17F15(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 Twice(this Vector3U18F14 x) => new Vector3U18F14(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 Twice(this Vector3U19F13 x) => new Vector3U19F13(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 Twice(this Vector3U20F12 x) => new Vector3U20F12(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 Twice(this Vector3U21F11 x) => new Vector3U21F11(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 Twice(this Vector3U22F10 x) => new Vector3U22F10(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 Twice(this Vector3U23F9 x) => new Vector3U23F9(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 Twice(this Vector3U24F8 x) => new Vector3U24F8(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 Twice(this Vector3U25F7 x) => new Vector3U25F7(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 Twice(this Vector3U26F6 x) => new Vector3U26F6(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 Twice(this Vector3U27F5 x) => new Vector3U27F5(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 Twice(this Vector3U28F4 x) => new Vector3U28F4(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 Twice(this Vector3U29F3 x) => new Vector3U29F3(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 Twice(this Vector3U30F2 x) => new Vector3U30F2(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 Twice(this Vector3U31F1 x) => new Vector3U31F1(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 Twice(this Vector4I2F30 x) => new Vector4I2F30(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 Twice(this Vector4I3F29 x) => new Vector4I3F29(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 Twice(this Vector4I4F28 x) => new Vector4I4F28(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 Twice(this Vector4I5F27 x) => new Vector4I5F27(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 Twice(this Vector4I6F26 x) => new Vector4I6F26(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 Twice(this Vector4I7F25 x) => new Vector4I7F25(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 Twice(this Vector4I8F24 x) => new Vector4I8F24(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 Twice(this Vector4I9F23 x) => new Vector4I9F23(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 Twice(this Vector4I10F22 x) => new Vector4I10F22(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 Twice(this Vector4I11F21 x) => new Vector4I11F21(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 Twice(this Vector4I12F20 x) => new Vector4I12F20(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 Twice(this Vector4I13F19 x) => new Vector4I13F19(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 Twice(this Vector4I14F18 x) => new Vector4I14F18(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 Twice(this Vector4I15F17 x) => new Vector4I15F17(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 Twice(this Vector4I16F16 x) => new Vector4I16F16(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 Twice(this Vector4I17F15 x) => new Vector4I17F15(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 Twice(this Vector4I18F14 x) => new Vector4I18F14(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 Twice(this Vector4I19F13 x) => new Vector4I19F13(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 Twice(this Vector4I20F12 x) => new Vector4I20F12(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 Twice(this Vector4I21F11 x) => new Vector4I21F11(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 Twice(this Vector4I22F10 x) => new Vector4I22F10(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 Twice(this Vector4I23F9 x) => new Vector4I23F9(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 Twice(this Vector4I24F8 x) => new Vector4I24F8(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 Twice(this Vector4I25F7 x) => new Vector4I25F7(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 Twice(this Vector4I26F6 x) => new Vector4I26F6(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 Twice(this Vector4I27F5 x) => new Vector4I27F5(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 Twice(this Vector4I28F4 x) => new Vector4I28F4(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 Twice(this Vector4I29F3 x) => new Vector4I29F3(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 Twice(this Vector4I30F2 x) => new Vector4I30F2(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 Twice(this Vector4I31F1 x) => new Vector4I31F1(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 Twice(this Vector4U2F30 x) => new Vector4U2F30(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 Twice(this Vector4U3F29 x) => new Vector4U3F29(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 Twice(this Vector4U4F28 x) => new Vector4U4F28(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 Twice(this Vector4U5F27 x) => new Vector4U5F27(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 Twice(this Vector4U6F26 x) => new Vector4U6F26(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 Twice(this Vector4U7F25 x) => new Vector4U7F25(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 Twice(this Vector4U8F24 x) => new Vector4U8F24(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 Twice(this Vector4U9F23 x) => new Vector4U9F23(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 Twice(this Vector4U10F22 x) => new Vector4U10F22(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 Twice(this Vector4U11F21 x) => new Vector4U11F21(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 Twice(this Vector4U12F20 x) => new Vector4U12F20(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 Twice(this Vector4U13F19 x) => new Vector4U13F19(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 Twice(this Vector4U14F18 x) => new Vector4U14F18(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 Twice(this Vector4U15F17 x) => new Vector4U15F17(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 Twice(this Vector4U16F16 x) => new Vector4U16F16(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 Twice(this Vector4U17F15 x) => new Vector4U17F15(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 Twice(this Vector4U18F14 x) => new Vector4U18F14(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 Twice(this Vector4U19F13 x) => new Vector4U19F13(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 Twice(this Vector4U20F12 x) => new Vector4U20F12(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 Twice(this Vector4U21F11 x) => new Vector4U21F11(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 Twice(this Vector4U22F10 x) => new Vector4U22F10(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 Twice(this Vector4U23F9 x) => new Vector4U23F9(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 Twice(this Vector4U24F8 x) => new Vector4U24F8(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 Twice(this Vector4U25F7 x) => new Vector4U25F7(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 Twice(this Vector4U26F6 x) => new Vector4U26F6(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 Twice(this Vector4U27F5 x) => new Vector4U27F5(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 Twice(this Vector4U28F4 x) => new Vector4U28F4(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 Twice(this Vector4U29F3 x) => new Vector4U29F3(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 Twice(this Vector4U30F2 x) => new Vector4U30F2(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 Twice(this Vector4U31F1 x) => new Vector4U31F1(
            x.X.Twice(),
            x.Y.Twice(),
            x.Z.Twice(),
            x.W.Twice());

    }
}
