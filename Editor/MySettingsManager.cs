using UnityEditor.SettingsManagement;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    internal static class MySettingsManager
    {
        private static Settings s_instance;

        /// <summary>
        /// Return singleton <c>Settings</c> instance.
        /// This Settings has only <c>UserSettingsRepository</c>.
        /// Because if use `new Settings(string , string)`, an empty configuration file is created under ProjectSettings/ directory.
        /// </summary>
        internal static Settings Instance
        {
            get => s_instance ?? (s_instance = new Settings(new[] {new UserSettingsRepository()}));
        }
    }
}
