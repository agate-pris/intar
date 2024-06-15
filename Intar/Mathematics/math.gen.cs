#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
using static Unity.Mathematics.math;
#endif

namespace AgatePris.Intar.Mathematics {
    public static partial class math {

        public static long2 aslong(this int2 x) => long2(
            x.x,
            x.y);

        public static long3 aslong(this int3 x) => long3(
            x.x,
            x.y,
            x.z);

        public static long4 aslong(this int4 x) => long4(
            x.x,
            x.y,
            x.z,
            x.w);

        public static int2 asbits(this I2F30_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I3F29_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I4F28_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I5F27_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I6F26_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I7F25_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I8F24_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I9F23_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I10F22_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I11F21_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I12F20_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I13F19_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I14F18_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I15F17_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I16F16_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I17F15_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I18F14_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I19F13_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I20F12_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I21F11_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I22F10_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I23F9_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I24F8_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I25F7_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I26F6_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I27F5_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I28F4_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I29F3_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I30F2_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static int2 asbits(this I31F1_2 x) => int2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U2F30_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U3F29_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U4F28_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U5F27_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U6F26_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U7F25_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U8F24_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U9F23_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U10F22_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U11F21_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U12F20_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U13F19_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U14F18_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U15F17_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U16F16_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U17F15_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U18F14_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U19F13_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U20F12_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U21F11_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U22F10_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U23F9_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U24F8_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U25F7_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U26F6_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U27F5_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U28F4_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U29F3_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U30F2_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static uint2 asbits(this U31F1_2 x) => uint2(
            x.x.Bits,
            x.y.Bits);

        public static int3 asbits(this I2F30_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I3F29_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I4F28_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I5F27_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I6F26_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I7F25_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I8F24_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I9F23_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I10F22_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I11F21_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I12F20_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I13F19_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I14F18_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I15F17_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I16F16_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I17F15_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I18F14_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I19F13_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I20F12_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I21F11_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I22F10_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I23F9_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I24F8_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I25F7_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I26F6_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I27F5_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I28F4_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I29F3_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I30F2_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int3 asbits(this I31F1_3 x) => int3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U2F30_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U3F29_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U4F28_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U5F27_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U6F26_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U7F25_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U8F24_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U9F23_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U10F22_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U11F21_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U12F20_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U13F19_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U14F18_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U15F17_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U16F16_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U17F15_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U18F14_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U19F13_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U20F12_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U21F11_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U22F10_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U23F9_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U24F8_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U25F7_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U26F6_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U27F5_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U28F4_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U29F3_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U30F2_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static uint3 asbits(this U31F1_3 x) => uint3(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits);

        public static int4 asbits(this I2F30_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I3F29_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I4F28_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I5F27_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I6F26_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I7F25_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I8F24_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I9F23_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I10F22_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I11F21_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I12F20_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I13F19_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I14F18_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I15F17_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I16F16_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I17F15_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I18F14_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I19F13_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I20F12_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I21F11_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I22F10_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I23F9_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I24F8_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I25F7_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I26F6_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I27F5_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I28F4_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I29F3_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I30F2_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static int4 asbits(this I31F1_4 x) => int4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U2F30_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U3F29_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U4F28_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U5F27_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U6F26_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U7F25_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U8F24_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U9F23_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U10F22_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U11F21_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U12F20_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U13F19_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U14F18_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U15F17_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U16F16_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U17F15_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U18F14_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U19F13_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U20F12_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U21F11_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U22F10_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U23F9_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U24F8_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U25F7_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U26F6_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U27F5_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U28F4_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U29F3_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U30F2_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

        public static uint4 asbits(this U31F1_4 x) => uint4(
            x.x.Bits,
            x.y.Bits,
            x.z.Bits,
            x.w.Bits);

    }
}
