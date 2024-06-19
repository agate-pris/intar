namespace AgatePris.Intar.Integer {
    public static partial class BitOperations {
#if !NET7_0_OR_GREATER
        const int bitsOfInt = sizeof(int) * 8;
        const int bitsOfLong = sizeof(long) * 8;
#endif
    }
}
