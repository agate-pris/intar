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

    public interface IVectorComponentRespective<T> {
        /// <summary>
        /// <para>Gets or sets the element at the specified index.</para>
        /// <para>指定したインデックスにある要素を取得または設定します｡</para>
        /// </summary>
        /// <param name="index">
        /// <para>The zero-based index of the element to get or set.</para>
        /// <para>取得または設定する要素の、0 から始まるインデックス番号｡</para>
        /// </param>
        T this[int index] { get; set; }
    }
}
