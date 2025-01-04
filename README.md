# Intar

Intar is integer arithmetic library for .NET / [Unity](https://unity.com)

## Coordinate Transformations

```cs
var position = Vector3I17F15.One;
var t = Vector3I17F15.UnitX;
var r = QuaternionI2F30.RotateXP5(I17F15.One);
var s = Vector3I17F15.One;
var matrix = AffineTransform3I17F15.Trs(t, r, s);
position = matrix * position;
```

The above code has the same meaning as the following code.

```cs
var position = System.Numerics.Vector3.One;
var t = System.Numerics.Vector3.UnitX;
var r = System.Numerics.Quaternion.CreateFromYawPitchRoll(
    0.0f, (float)(0.5 * Math.PI), 0.0f
);
var s = System.Numerics.Vector3.One;
var matrix
    = System.Numerics.Matrix4x4.CreateScale(s)
    * System.Numerics.Matrix4x4.CreateFromQuaternion(r)
    * System.Numerics.Matrix4x4.CreateTranslation(t);
position = System.Numerics.Vector3.Transform(position, matrix);
```

## Links

- [Documentation](https://agate-pris.github.io/intar/)
- [Nuget Package](https://www.nuget.org/packages/Intar)
- [Release Notes](https://github.com/agate-pris/intar/releases)
- [License](https://github.com/agate-pris/intar/blob/master/LICENSE.md)
