using UnityEditor;
using UnityEditor.SettingsManagement;
using UnityEngine;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    internal static class BlenderLikeSceneViewHotkeys
    {
        private const string PackageName = "com.nowsprinting.blender-like-sceneview-hotkeys";
        private const float OrbitStepAngleDegrees = 15f;
        private const float OrbitOppositeSideAngleDegrees = 180f;

        [UserSetting("Input", "Emulate Numpad")]
        private static readonly UserSetting<bool> EmulateNumpad = new UserSetting<bool>(MySettingsManager.Instance,
            $"{PackageName}.EmulateNumpad", false, SettingsScope.User);

        [InitializeOnLoadMethod]
        private static void InitializeSceneViewOnGuiDelegate()
        {
#if UNITY_2019_1_OR_NEWER
            SceneView.duringSceneGui += OnGUI;
#else
            SceneView.onSceneGUIDelegate += OnGUI;
#endif
        }

        private static void OnGUI(SceneView sceneView)
        {
            var e = Event.current;
            if (e.type != EventType.KeyDown)
            {
                return;
            }

            var key = e.keyCode;
            if (EmulateNumpad.value)
            {
                key = KeypadKeycodeFromAlpha(key);
            }

            if (e.control)
            {
                // with control key
                switch (key)
                {
                    case KeyCode.Keypad1:
                        sceneView.SetDirection(Vector3.forward);
                        break;
                    case KeyCode.Keypad3:
                        sceneView.SetDirection(Vector3.left);
                        break;
                    case KeyCode.Keypad7:
                        sceneView.SetDirection(Vector3.up);
                        break;
                    // case KeyCode.Keypad2:
                    //     sceneView.Pan(Vector3.down);
                    //     break;
                    // case KeyCode.Keypad4:
                    //     sceneView.Pan(Vector3.left);
                    //     break;
                    // case KeyCode.Keypad6:
                    //     sceneView.Pan(Vector3.right);
                    //     break;
                    // case KeyCode.Keypad8:
                    //     sceneView.Pan(Vector3.up);
                    //     break;
                    default:
                        return;
                }
            }
            else
            {
                // without control key
                switch (key)
                {
                    case KeyCode.Keypad1:
                        sceneView.SetDirection(Vector3.back);
                        break;
                    case KeyCode.Keypad3:
                        sceneView.SetDirection(Vector3.right);
                        break;
                    case KeyCode.Keypad7:
                        sceneView.SetDirection(Vector3.down);
                        break;
                    case KeyCode.Keypad2:
                        sceneView.OrbitX(OrbitStepAngleDegrees * -1);
                        break;
                    case KeyCode.Keypad4:
                        sceneView.OrbitY(OrbitStepAngleDegrees);
                        break;
                    case KeyCode.Keypad6:
                        sceneView.OrbitY(OrbitStepAngleDegrees * -1);
                        break;
                    case KeyCode.Keypad8:
                        sceneView.OrbitX(OrbitStepAngleDegrees);
                        break;
                    case KeyCode.Keypad5:
                        sceneView.ToggleOrthographicProjection();
                        break;
                    case KeyCode.Keypad9:
                        sceneView.OrbitY(OrbitOppositeSideAngleDegrees);
                        break;
                    // case KeyCode.Keypad0:
                    //     sceneView.ToggleLookFromMainCamera();
                    //     break;
                    // case KeyCode.KeypadPeriod:
                    //     sceneView.ZoomToSelectedObject();
                    //     break;
                    // case KeyCode.KeypadPlus:
                    //     sceneView.ZoomIn();
                    //     break;
                    // case KeyCode.KeypadMinus:
                    //     sceneView.ZoomOut();
                    //     break;
                    default:
                        return;
                }
            }

            e.Use();
        }

        private static KeyCode KeypadKeycodeFromAlpha(KeyCode src)
        {
            if (KeyCode.Alpha0 <= src && src <= KeyCode.Alpha9)
            {
                return src + (KeyCode.Keypad0 - KeyCode.Alpha0);
            }

            switch (src)
            {
                case KeyCode.Period:
                    return KeyCode.KeypadPeriod;
                case KeyCode.Plus:
                    return KeyCode.KeypadPlus;
                case KeyCode.Minus:
                    return KeyCode.KeypadMinus;
            }

            return src;
        }
    }
}
