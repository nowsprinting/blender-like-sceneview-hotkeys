using System;
using UnityEditor;
using UnityEngine;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    public static class SceneViewExtensions
    {
        public static void SetDirection(this SceneView sceneView, Vector3 direction)
        {
            sceneView.rotation = Quaternion.LookRotation(direction);
            if (direction == Vector3.down || direction == Vector3.up)
            {
                sceneView.rotation *= Quaternion.AngleAxis(180f, new Vector3(0f, 0f, 1f));
            }
        }

        public static void OrbitX(this SceneView sceneView, float angle)
        {
            sceneView.rotation *= Quaternion.AngleAxis(angle, new Vector3(1f, 0f, 0f));
        }

        public static void OrbitY(this SceneView sceneView, float angle)
        {
            var rotationX = Quaternion.Euler(new Vector3(sceneView.rotation.eulerAngles.x, 0f, 0f));
            sceneView.rotation *= Quaternion.Inverse(rotationX);
            sceneView.rotation *= Quaternion.AngleAxis(angle, new Vector3(0f, 1f, 0f));
            sceneView.rotation *= rotationX;
        }

        public static void OppositeSide(this SceneView sceneView)
        {
            var rotationAngleX = sceneView.rotation.eulerAngles.x;
            var rotationAngleY = sceneView.rotation.eulerAngles.y;
            if ((Math.Abs(rotationAngleX - 90f) == 0f || Math.Abs(rotationAngleX - 270f) == 0f) &&
                (rotationAngleY == 0f || Math.Abs(rotationAngleY - 180f) == 0f))
            {
                sceneView.OrbitX(180f);
            }
            else
            {
                sceneView.OrbitY(180f);
            }
        }

        public static void Pan(this SceneView sceneView, Vector3 direction)
        {
            // TODO: move sceneView.pivot
        }

        public static void ToggleOrthographicProjection(this SceneView sceneView)
        {
            sceneView.orthographic = !sceneView.orthographic;
        }

        public static void ToggleLookFromMainCamera(this SceneView sceneView)
        {
            // TODO:
        }

        public static void ZoomToSelectedObject(this SceneView sceneView)
        {
            // TODO: same as shift + F
            // use `Selection.activeTransform` and `SceneView.LookAtDirect`
        }

        public static void ZoomIn(this SceneView sceneView)
        {
            sceneView.Zoom(Vector3.forward);
        }

        public static void ZoomOut(this SceneView sceneView)
        {
            sceneView.Zoom(Vector3.back);
        }

        private static void Zoom(this SceneView sceneView, Vector3 normalizedDirection)
        {
            // TODO:
        }
    }
}
