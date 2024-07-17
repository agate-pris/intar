namespace AgatePris.Intar.Numerics {
    public interface IVector<
        TLengthSquaredUnsigned, TLengthSquaredSigned,
        TLengthUnsigned, TLengthSigned
    > {
        TLengthSquaredUnsigned LengthSquaredUnsigned();
        TLengthSquaredSigned LengthSquaredSigned();
        TLengthUnsigned LengthUnsigned();
        TLengthSigned LengthSigned();
    }
}
