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

        public static void InverseDirection(this SceneView sceneView)
        {
            sceneView.rotation *= Quaternion.AngleAxis(180f, Vector3.down);
        }

        public static void Orbit(this SceneView sceneView, Vector3 direction)
        {
            sceneView.rotation *= Quaternion.AngleAxis(15f, direction);
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
        }

        public static void ZoomIn(this SceneView sceneView)
        {
            Zoom(sceneView, Vector3.forward);
        }

        public static void ZoomOut(this SceneView sceneView)
        {
            Zoom(sceneView, Vector3.back);
        }

        private static void Zoom(SceneView sceneView, Vector3 normalizedDirection)
        {
            // TODO:
        }
    }
}