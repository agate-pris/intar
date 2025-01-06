#if UNITY_5_3_OR_NEWER

using Intar;
using Intar.Geometry;
using UnityEngine;

public class ExampleScript : MonoBehaviour {
    public Vector2I17F15 Point;
    public CircleI17F15 Circle;
    public Segment2I17F15 Segment;
    public Box2I17F15 Box1;
    public Box2I17F15 Box2;
    public Transform PointTransform;
    public Transform CircleTransform;
    public Transform SegmentTransform;
    public Transform Box1Transform;
    public Transform Box2Transform;

#if UNITY_EDITOR
    void OnDrawGizmos() {
        if (!isActiveAndEnabled) {
            return;
        }
        var circle = (AffineTransform3I17F15)(CircleTransform ? CircleTransform.localToWorldMatrix : Matrix4x4.identity) * Circle;
        var segment = (AffineTransform3I17F15)(SegmentTransform ? SegmentTransform.localToWorldMatrix : Matrix4x4.identity) * Segment;
        var box1 = (AffineTransform3I17F15)(Box1Transform ? Box1Transform.localToWorldMatrix : Matrix4x4.identity) * Box1;
        var box2 = (AffineTransform3I17F15)(Box2Transform ? Box2Transform.localToWorldMatrix : Matrix4x4.identity) * Box2;

        new Segment2I17F15(Point, Point).Draw(PointTransform ? PointTransform.position.z : 0);

        Gizmos.color = box1.Intersects(Point) ? Color.red : Color.green;
        box1.Draw(CircleTransform ? CircleTransform.position.z : 0);

        Gizmos.color = box1.Intersects(Circle) ? Color.red : Color.green;
        circle.Draw(CircleTransform ? CircleTransform.position.z : 0);

        Gizmos.color = box1.Intersects(segment) ? Color.red : Color.green;
        segment.Draw(SegmentTransform ? SegmentTransform.position.z : 0);

        Gizmos.color = box2.Intersects(box1) ? Color.red : Color.green;
        box2.Draw(Box2Transform ? Box2Transform.position.z : 0);
    }
#endif // UNITY_EDITOR
}

#endif
