using UnityEditor.SettingsManagement;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    internal static class MySettingsManager
    {
        private static Settings s_instance;

        /// <summary>
        /// Return singleton <c>Settings</c> instance.
        /// This Settings has only <c>UserSettingsRepository</c>.
        /// </summary>
        internal static Settings Instance
        {
            get => s_instance ?? (s_instance = new Settings(new[] {new UserSettingsRepository()}));
        }
    }
}