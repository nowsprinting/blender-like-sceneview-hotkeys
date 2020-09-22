using UnityEditor;
using UnityEngine;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    public static class SceneViewExtensions
    {
        public static void SetDirection(this SceneView sceneView, Vector3 direction)
        {
            sceneView.rotation = Quaternion.LookRotation(direction);
        }

        public static void OrbitX(this SceneView sceneView, float angle)
        {
            sceneView.Orbit(angle, new Vector3(1f, 0f, 0f));
        }

        public static void OrbitY(this SceneView sceneView, float angle)
        {
            sceneView.Orbit(angle, new Vector3(0f, 1f, 0f));
        }

        private static void Orbit(this SceneView sceneView, float angle, Vector3 axis)
        {
            sceneView.rotation *= Quaternion.AngleAxis(angle, axis);
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
