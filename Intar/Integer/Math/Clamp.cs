using i08 = System.SByte;
using i16 = System.Int16;
using i32 = System.Int32;
using i64 = System.Int64;
using u08 = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace AgatePris.Intar.Integer {
    public static partial class Math {
        public static i08 Clamp(this i08 x, i08 min, i08 max) => x < min ? min : (x > max ? max : x);
        public static i16 Clamp(this i16 x, i16 min, i16 max) => x < min ? min : (x > max ? max : x);
        public static i32 Clamp(this i32 x, i32 min, i32 max) => x < min ? min : (x > max ? max : x);
        public static i64 Clamp(this i64 x, i64 min, i64 max) => x < min ? min : (x > max ? max : x);
        public static u08 Clamp(this u08 x, u08 min, u08 max) => x < min ? min : (x > max ? max : x);
        public static u16 Clamp(this u16 x, u16 min, u16 max) => x < min ? min : (x > max ? max : x);
        public static u32 Clamp(this u32 x, u32 min, u32 max) => x < min ? min : (x > max ? max : x);
        public static u64 Clamp(this u64 x, u64 min, u64 max) => x < min ? min : (x > max ? max : x);
    }
}
