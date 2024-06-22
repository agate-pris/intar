using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int v, int min, int max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint v, uint min, uint max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long v, long min, long max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong v, ulong min, ulong max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short v, short min, short max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort v, ushort min, ushort max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte v, byte min, byte max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte v, sbyte min, sbyte max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }




        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I2F30 Clamp(this I2F30 x, I2F30 min, I2F30 max) => I2F30.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I3F29 Clamp(this I3F29 x, I3F29 min, I3F29 max) => I3F29.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I4F28 Clamp(this I4F28 x, I4F28 min, I4F28 max) => I4F28.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I5F27 Clamp(this I5F27 x, I5F27 min, I5F27 max) => I5F27.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I6F26 Clamp(this I6F26 x, I6F26 min, I6F26 max) => I6F26.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I7F25 Clamp(this I7F25 x, I7F25 min, I7F25 max) => I7F25.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I8F24 Clamp(this I8F24 x, I8F24 min, I8F24 max) => I8F24.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I9F23 Clamp(this I9F23 x, I9F23 min, I9F23 max) => I9F23.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I10F22 Clamp(this I10F22 x, I10F22 min, I10F22 max) => I10F22.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I11F21 Clamp(this I11F21 x, I11F21 min, I11F21 max) => I11F21.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I12F20 Clamp(this I12F20 x, I12F20 min, I12F20 max) => I12F20.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I13F19 Clamp(this I13F19 x, I13F19 min, I13F19 max) => I13F19.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I14F18 Clamp(this I14F18 x, I14F18 min, I14F18 max) => I14F18.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I15F17 Clamp(this I15F17 x, I15F17 min, I15F17 max) => I15F17.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I16F16 Clamp(this I16F16 x, I16F16 min, I16F16 max) => I16F16.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I17F15 Clamp(this I17F15 x, I17F15 min, I17F15 max) => I17F15.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I18F14 Clamp(this I18F14 x, I18F14 min, I18F14 max) => I18F14.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I19F13 Clamp(this I19F13 x, I19F13 min, I19F13 max) => I19F13.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I20F12 Clamp(this I20F12 x, I20F12 min, I20F12 max) => I20F12.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I21F11 Clamp(this I21F11 x, I21F11 min, I21F11 max) => I21F11.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I22F10 Clamp(this I22F10 x, I22F10 min, I22F10 max) => I22F10.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I23F9 Clamp(this I23F9 x, I23F9 min, I23F9 max) => I23F9.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I24F8 Clamp(this I24F8 x, I24F8 min, I24F8 max) => I24F8.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I25F7 Clamp(this I25F7 x, I25F7 min, I25F7 max) => I25F7.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I26F6 Clamp(this I26F6 x, I26F6 min, I26F6 max) => I26F6.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I27F5 Clamp(this I27F5 x, I27F5 min, I27F5 max) => I27F5.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I28F4 Clamp(this I28F4 x, I28F4 min, I28F4 max) => I28F4.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I29F3 Clamp(this I29F3 x, I29F3 min, I29F3 max) => I29F3.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I30F2 Clamp(this I30F2 x, I30F2 min, I30F2 max) => I30F2.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I31F1 Clamp(this I31F1 x, I31F1 min, I31F1 max) => I31F1.FromBits(Clamp(x.Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U2F30 Clamp(this U2F30 x, U2F30 min, U2F30 max) => U2F30.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U3F29 Clamp(this U3F29 x, U3F29 min, U3F29 max) => U3F29.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U4F28 Clamp(this U4F28 x, U4F28 min, U4F28 max) => U4F28.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U5F27 Clamp(this U5F27 x, U5F27 min, U5F27 max) => U5F27.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U6F26 Clamp(this U6F26 x, U6F26 min, U6F26 max) => U6F26.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U7F25 Clamp(this U7F25 x, U7F25 min, U7F25 max) => U7F25.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U8F24 Clamp(this U8F24 x, U8F24 min, U8F24 max) => U8F24.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U9F23 Clamp(this U9F23 x, U9F23 min, U9F23 max) => U9F23.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U10F22 Clamp(this U10F22 x, U10F22 min, U10F22 max) => U10F22.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U11F21 Clamp(this U11F21 x, U11F21 min, U11F21 max) => U11F21.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U12F20 Clamp(this U12F20 x, U12F20 min, U12F20 max) => U12F20.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U13F19 Clamp(this U13F19 x, U13F19 min, U13F19 max) => U13F19.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U14F18 Clamp(this U14F18 x, U14F18 min, U14F18 max) => U14F18.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U15F17 Clamp(this U15F17 x, U15F17 min, U15F17 max) => U15F17.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U16F16 Clamp(this U16F16 x, U16F16 min, U16F16 max) => U16F16.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U17F15 Clamp(this U17F15 x, U17F15 min, U17F15 max) => U17F15.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U18F14 Clamp(this U18F14 x, U18F14 min, U18F14 max) => U18F14.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U19F13 Clamp(this U19F13 x, U19F13 min, U19F13 max) => U19F13.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U20F12 Clamp(this U20F12 x, U20F12 min, U20F12 max) => U20F12.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U21F11 Clamp(this U21F11 x, U21F11 min, U21F11 max) => U21F11.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U22F10 Clamp(this U22F10 x, U22F10 min, U22F10 max) => U22F10.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U23F9 Clamp(this U23F9 x, U23F9 min, U23F9 max) => U23F9.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U24F8 Clamp(this U24F8 x, U24F8 min, U24F8 max) => U24F8.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U25F7 Clamp(this U25F7 x, U25F7 min, U25F7 max) => U25F7.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U26F6 Clamp(this U26F6 x, U26F6 min, U26F6 max) => U26F6.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U27F5 Clamp(this U27F5 x, U27F5 min, U27F5 max) => U27F5.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U28F4 Clamp(this U28F4 x, U28F4 min, U28F4 max) => U28F4.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U29F3 Clamp(this U29F3 x, U29F3 min, U29F3 max) => U29F3.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U30F2 Clamp(this U30F2 x, U30F2 min, U30F2 max) => U30F2.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U31F1 Clamp(this U31F1 x, U31F1 min, U31F1 max) => U31F1.FromBits(Clamp(x.Bits, min.Bits, max.Bits));


        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I2F62 Clamp(this I2F62 x, I2F62 min, I2F62 max) => I2F62.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I3F61 Clamp(this I3F61 x, I3F61 min, I3F61 max) => I3F61.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I4F60 Clamp(this I4F60 x, I4F60 min, I4F60 max) => I4F60.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I5F59 Clamp(this I5F59 x, I5F59 min, I5F59 max) => I5F59.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I6F58 Clamp(this I6F58 x, I6F58 min, I6F58 max) => I6F58.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I7F57 Clamp(this I7F57 x, I7F57 min, I7F57 max) => I7F57.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I8F56 Clamp(this I8F56 x, I8F56 min, I8F56 max) => I8F56.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I9F55 Clamp(this I9F55 x, I9F55 min, I9F55 max) => I9F55.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I10F54 Clamp(this I10F54 x, I10F54 min, I10F54 max) => I10F54.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I11F53 Clamp(this I11F53 x, I11F53 min, I11F53 max) => I11F53.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I12F52 Clamp(this I12F52 x, I12F52 min, I12F52 max) => I12F52.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I13F51 Clamp(this I13F51 x, I13F51 min, I13F51 max) => I13F51.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I14F50 Clamp(this I14F50 x, I14F50 min, I14F50 max) => I14F50.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I15F49 Clamp(this I15F49 x, I15F49 min, I15F49 max) => I15F49.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I16F48 Clamp(this I16F48 x, I16F48 min, I16F48 max) => I16F48.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I17F47 Clamp(this I17F47 x, I17F47 min, I17F47 max) => I17F47.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I18F46 Clamp(this I18F46 x, I18F46 min, I18F46 max) => I18F46.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I19F45 Clamp(this I19F45 x, I19F45 min, I19F45 max) => I19F45.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I20F44 Clamp(this I20F44 x, I20F44 min, I20F44 max) => I20F44.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I21F43 Clamp(this I21F43 x, I21F43 min, I21F43 max) => I21F43.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I22F42 Clamp(this I22F42 x, I22F42 min, I22F42 max) => I22F42.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I23F41 Clamp(this I23F41 x, I23F41 min, I23F41 max) => I23F41.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I24F40 Clamp(this I24F40 x, I24F40 min, I24F40 max) => I24F40.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I25F39 Clamp(this I25F39 x, I25F39 min, I25F39 max) => I25F39.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I26F38 Clamp(this I26F38 x, I26F38 min, I26F38 max) => I26F38.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I27F37 Clamp(this I27F37 x, I27F37 min, I27F37 max) => I27F37.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I28F36 Clamp(this I28F36 x, I28F36 min, I28F36 max) => I28F36.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I29F35 Clamp(this I29F35 x, I29F35 min, I29F35 max) => I29F35.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I30F34 Clamp(this I30F34 x, I30F34 min, I30F34 max) => I30F34.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I31F33 Clamp(this I31F33 x, I31F33 min, I31F33 max) => I31F33.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I32F32 Clamp(this I32F32 x, I32F32 min, I32F32 max) => I32F32.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I33F31 Clamp(this I33F31 x, I33F31 min, I33F31 max) => I33F31.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I34F30 Clamp(this I34F30 x, I34F30 min, I34F30 max) => I34F30.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I35F29 Clamp(this I35F29 x, I35F29 min, I35F29 max) => I35F29.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I36F28 Clamp(this I36F28 x, I36F28 min, I36F28 max) => I36F28.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I37F27 Clamp(this I37F27 x, I37F27 min, I37F27 max) => I37F27.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I38F26 Clamp(this I38F26 x, I38F26 min, I38F26 max) => I38F26.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I39F25 Clamp(this I39F25 x, I39F25 min, I39F25 max) => I39F25.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I40F24 Clamp(this I40F24 x, I40F24 min, I40F24 max) => I40F24.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I41F23 Clamp(this I41F23 x, I41F23 min, I41F23 max) => I41F23.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I42F22 Clamp(this I42F22 x, I42F22 min, I42F22 max) => I42F22.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I43F21 Clamp(this I43F21 x, I43F21 min, I43F21 max) => I43F21.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I44F20 Clamp(this I44F20 x, I44F20 min, I44F20 max) => I44F20.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I45F19 Clamp(this I45F19 x, I45F19 min, I45F19 max) => I45F19.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I46F18 Clamp(this I46F18 x, I46F18 min, I46F18 max) => I46F18.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I47F17 Clamp(this I47F17 x, I47F17 min, I47F17 max) => I47F17.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I48F16 Clamp(this I48F16 x, I48F16 min, I48F16 max) => I48F16.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I49F15 Clamp(this I49F15 x, I49F15 min, I49F15 max) => I49F15.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I50F14 Clamp(this I50F14 x, I50F14 min, I50F14 max) => I50F14.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I51F13 Clamp(this I51F13 x, I51F13 min, I51F13 max) => I51F13.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I52F12 Clamp(this I52F12 x, I52F12 min, I52F12 max) => I52F12.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I53F11 Clamp(this I53F11 x, I53F11 min, I53F11 max) => I53F11.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I54F10 Clamp(this I54F10 x, I54F10 min, I54F10 max) => I54F10.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I55F9 Clamp(this I55F9 x, I55F9 min, I55F9 max) => I55F9.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I56F8 Clamp(this I56F8 x, I56F8 min, I56F8 max) => I56F8.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I57F7 Clamp(this I57F7 x, I57F7 min, I57F7 max) => I57F7.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I58F6 Clamp(this I58F6 x, I58F6 min, I58F6 max) => I58F6.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I59F5 Clamp(this I59F5 x, I59F5 min, I59F5 max) => I59F5.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I60F4 Clamp(this I60F4 x, I60F4 min, I60F4 max) => I60F4.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I61F3 Clamp(this I61F3 x, I61F3 min, I61F3 max) => I61F3.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I62F2 Clamp(this I62F2 x, I62F2 min, I62F2 max) => I62F2.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static I63F1 Clamp(this I63F1 x, I63F1 min, I63F1 max) => I63F1.FromBits(Clamp(x.Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U2F62 Clamp(this U2F62 x, U2F62 min, U2F62 max) => U2F62.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U3F61 Clamp(this U3F61 x, U3F61 min, U3F61 max) => U3F61.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U4F60 Clamp(this U4F60 x, U4F60 min, U4F60 max) => U4F60.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U5F59 Clamp(this U5F59 x, U5F59 min, U5F59 max) => U5F59.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U6F58 Clamp(this U6F58 x, U6F58 min, U6F58 max) => U6F58.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U7F57 Clamp(this U7F57 x, U7F57 min, U7F57 max) => U7F57.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U8F56 Clamp(this U8F56 x, U8F56 min, U8F56 max) => U8F56.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U9F55 Clamp(this U9F55 x, U9F55 min, U9F55 max) => U9F55.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U10F54 Clamp(this U10F54 x, U10F54 min, U10F54 max) => U10F54.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U11F53 Clamp(this U11F53 x, U11F53 min, U11F53 max) => U11F53.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U12F52 Clamp(this U12F52 x, U12F52 min, U12F52 max) => U12F52.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U13F51 Clamp(this U13F51 x, U13F51 min, U13F51 max) => U13F51.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U14F50 Clamp(this U14F50 x, U14F50 min, U14F50 max) => U14F50.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U15F49 Clamp(this U15F49 x, U15F49 min, U15F49 max) => U15F49.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U16F48 Clamp(this U16F48 x, U16F48 min, U16F48 max) => U16F48.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U17F47 Clamp(this U17F47 x, U17F47 min, U17F47 max) => U17F47.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U18F46 Clamp(this U18F46 x, U18F46 min, U18F46 max) => U18F46.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U19F45 Clamp(this U19F45 x, U19F45 min, U19F45 max) => U19F45.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U20F44 Clamp(this U20F44 x, U20F44 min, U20F44 max) => U20F44.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U21F43 Clamp(this U21F43 x, U21F43 min, U21F43 max) => U21F43.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U22F42 Clamp(this U22F42 x, U22F42 min, U22F42 max) => U22F42.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U23F41 Clamp(this U23F41 x, U23F41 min, U23F41 max) => U23F41.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U24F40 Clamp(this U24F40 x, U24F40 min, U24F40 max) => U24F40.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U25F39 Clamp(this U25F39 x, U25F39 min, U25F39 max) => U25F39.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U26F38 Clamp(this U26F38 x, U26F38 min, U26F38 max) => U26F38.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U27F37 Clamp(this U27F37 x, U27F37 min, U27F37 max) => U27F37.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U28F36 Clamp(this U28F36 x, U28F36 min, U28F36 max) => U28F36.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U29F35 Clamp(this U29F35 x, U29F35 min, U29F35 max) => U29F35.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U30F34 Clamp(this U30F34 x, U30F34 min, U30F34 max) => U30F34.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U31F33 Clamp(this U31F33 x, U31F33 min, U31F33 max) => U31F33.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U32F32 Clamp(this U32F32 x, U32F32 min, U32F32 max) => U32F32.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U33F31 Clamp(this U33F31 x, U33F31 min, U33F31 max) => U33F31.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U34F30 Clamp(this U34F30 x, U34F30 min, U34F30 max) => U34F30.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U35F29 Clamp(this U35F29 x, U35F29 min, U35F29 max) => U35F29.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U36F28 Clamp(this U36F28 x, U36F28 min, U36F28 max) => U36F28.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U37F27 Clamp(this U37F27 x, U37F27 min, U37F27 max) => U37F27.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U38F26 Clamp(this U38F26 x, U38F26 min, U38F26 max) => U38F26.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U39F25 Clamp(this U39F25 x, U39F25 min, U39F25 max) => U39F25.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U40F24 Clamp(this U40F24 x, U40F24 min, U40F24 max) => U40F24.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U41F23 Clamp(this U41F23 x, U41F23 min, U41F23 max) => U41F23.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U42F22 Clamp(this U42F22 x, U42F22 min, U42F22 max) => U42F22.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U43F21 Clamp(this U43F21 x, U43F21 min, U43F21 max) => U43F21.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U44F20 Clamp(this U44F20 x, U44F20 min, U44F20 max) => U44F20.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U45F19 Clamp(this U45F19 x, U45F19 min, U45F19 max) => U45F19.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U46F18 Clamp(this U46F18 x, U46F18 min, U46F18 max) => U46F18.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U47F17 Clamp(this U47F17 x, U47F17 min, U47F17 max) => U47F17.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U48F16 Clamp(this U48F16 x, U48F16 min, U48F16 max) => U48F16.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U49F15 Clamp(this U49F15 x, U49F15 min, U49F15 max) => U49F15.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U50F14 Clamp(this U50F14 x, U50F14 min, U50F14 max) => U50F14.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U51F13 Clamp(this U51F13 x, U51F13 min, U51F13 max) => U51F13.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U52F12 Clamp(this U52F12 x, U52F12 min, U52F12 max) => U52F12.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U53F11 Clamp(this U53F11 x, U53F11 min, U53F11 max) => U53F11.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U54F10 Clamp(this U54F10 x, U54F10 min, U54F10 max) => U54F10.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U55F9 Clamp(this U55F9 x, U55F9 min, U55F9 max) => U55F9.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U56F8 Clamp(this U56F8 x, U56F8 min, U56F8 max) => U56F8.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U57F7 Clamp(this U57F7 x, U57F7 min, U57F7 max) => U57F7.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U58F6 Clamp(this U58F6 x, U58F6 min, U58F6 max) => U58F6.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U59F5 Clamp(this U59F5 x, U59F5 min, U59F5 max) => U59F5.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U60F4 Clamp(this U60F4 x, U60F4 min, U60F4 max) => U60F4.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U61F3 Clamp(this U61F3 x, U61F3 min, U61F3 max) => U61F3.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U62F2 Clamp(this U62F2 x, U62F2 min, U62F2 max) => U62F2.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static U63F1 Clamp(this U63F1 x, U63F1 min, U63F1 max) => U63F1.FromBits(Clamp(x.Bits, min.Bits, max.Bits));

    }
}
