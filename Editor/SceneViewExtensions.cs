// Copyright (c) 2020-2023 Koji Hasegawa.
// This software is released under the MIT License.

using UnityEditor;
using UnityEngine;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    public static class SceneViewExtensions
    {
        private static readonly Vector3 s_xAxis = new Vector3(1f, 0f, 0f);
        private static readonly Vector3 s_yAxis = new Vector3(0f, 1f, 0f);
        private static readonly Vector3 s_zAxis = new Vector3(0f, 0f, 1f);
        private static readonly Vector3 s_topView = new Vector3(90f, 180f, 0f);
        private static readonly Vector3 s_bottomView = new Vector3(270f, 180f, 0f);

        public static void SetDirection(this SceneView sceneView, Vector3 direction)
        {
            sceneView.rotation = Quaternion.LookRotation(direction);
            if (direction == Vector3.down || direction == Vector3.up)
            {
                sceneView.rotation *= Quaternion.AngleAxis(180f, s_zAxis);
            }
        }

        public static void OrbitX(this SceneView sceneView, float angle)
        {
            sceneView.rotation *= Quaternion.AngleAxis(angle, s_xAxis);
        }

        public static void OrbitY(this SceneView sceneView, float angle)
        {
            var rotationX = Quaternion.Euler(new Vector3(sceneView.rotation.eulerAngles.x, 0f, 0f));
            sceneView.rotation *= Quaternion.Inverse(rotationX);
            sceneView.rotation *= Quaternion.AngleAxis(angle, s_yAxis);
            sceneView.rotation *= rotationX;
        }

        public static void OppositeSide(this SceneView sceneView)
        {
            var rotationEulerAngles = sceneView.rotation.eulerAngles;
            if (rotationEulerAngles == s_topView || rotationEulerAngles == s_bottomView)
            {
                sceneView.OrbitX(180f);
            }
            else
            {
                sceneView.OrbitY(180f);
            }
        }

        public static void Roll(this SceneView sceneView, float angle)
        {
            sceneView.rotation *= Quaternion.AngleAxis(angle, s_zAxis);
        }

        public static void Pan(this SceneView sceneView, Vector3 direction, float distanceCoefficient)
        {
            var movingDistance = sceneView.size * distanceCoefficient;
            sceneView.pivot += sceneView.rotation * direction * movingDistance;
        }

        public static void Zoom(this SceneView sceneView, float distance)
        {
            if (sceneView.size >= distance)
            {
                sceneView.size -= distance;
            }
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
    }
}
