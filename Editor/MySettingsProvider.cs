using UnityEditor;
using UnityEditor.SettingsManagement;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    internal static class MySettingsProvider
    {
        private const string PreferencesPath = "Preferences/Blender-like SceneView Hotkeys";

        [SettingsProvider]
        private static SettingsProvider CreateSettingsProvider()
        {
            return new UserSettingsProvider(PreferencesPath, MySettingsManager.Instance,
                new[] {typeof(MySettingsProvider).Assembly});
        }
    }
}