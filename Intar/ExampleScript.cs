#if UNITY_5_3_OR_NEWER

using Intar;
using Intar.Geometry;
using UnityEngine;

public class ExampleScript : MonoBehaviour {
    public CircleI17F15 Circle1;
    public CircleI17F15 Circle2;
    public CircleI17F15 Circle3;
    public Transform Circle1Transform;
    public Transform Circle2Transform;
    public Transform Circle3Transform;
    public Box2I17F15 Box1;
    public Box2I17F15 Box2;
    public Box2I17F15 Box3;
    public Transform Box1Transform;
    public Transform Box2Transform;
    public Transform Box3Transform;

#if UNITY_EDITOR
    void OnDrawGizmosSelected() {
        if (!isActiveAndEnabled) {
            return;
        }
        var circle1 = (AffineTransform3I17F15)(Circle1Transform ? Circle1Transform.localToWorldMatrix : Matrix4x4.identity) * Circle1;
        var circle2 = (AffineTransform3I17F15)(Circle2Transform ? Circle2Transform.localToWorldMatrix : Matrix4x4.identity) * Circle2;
        var circle3 = (AffineTransform3I17F15)(Circle3Transform ? Circle3Transform.localToWorldMatrix : Matrix4x4.identity) * Circle3;
        var box1 = (AffineTransform3I17F15)(Box1Transform ? Box1Transform.localToWorldMatrix : Matrix4x4.identity) * Box1;
        var box2 = (AffineTransform3I17F15)(Box2Transform ? Box2Transform.localToWorldMatrix : Matrix4x4.identity) * Box2;
        var box3 = (AffineTransform3I17F15)(Box3Transform ? Box3Transform.localToWorldMatrix : Matrix4x4.identity) * Box3;

        circle1.Draw(Circle1Transform ? Circle1Transform.position.z : 0);
        box1.Draw(Box1Transform ? Box1Transform.position.z : 0);

        Gizmos.color = circle1.Intersects(circle2) ? Color.red : Color.green;
        circle2.Draw(Circle2Transform ? Circle2Transform.position.z : 0);

        Gizmos.color = box1.Intersects(box2) ? Color.red : Color.green;
        box2.Draw(Box2Transform ? Box2Transform.position.z : 0);

        Gizmos.color = box3.Intersects(circle3) ? Color.red : Color.green;
        box3.Draw(Box3Transform ? Box3Transform.position.z : 0);
        circle3.Draw(Circle3Transform ? Circle3Transform.position.z : 0);
    }
#endif // UNITY_EDITOR
}

#endif
