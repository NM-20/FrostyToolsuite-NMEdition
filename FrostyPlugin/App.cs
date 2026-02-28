using Frosty.Core.Interfaces;
using FrostySdk;
using FrostySdk.Interfaces;
using FrostySdk.Managers;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Frosty.Core
{
    public sealed class App
    {
        private static readonly string s_applicationPath = Path.GetDirectoryName(typeof(App).Assembly.Location);

        public static AssetManager AssetManager;
        public static ResourceManager ResourceManager;
        public static FileSystem FileSystem;
        public static PluginManager PluginManager;
        public static EbxAssetEntry SelectedAsset;
        public static string SelectedProfile;
        public static string SelectedPack;
        public static ILogger Logger;
        public static HashSet<int> WhitelistedBundles = new HashSet<int>();

        public static readonly int Version = 1;

        /* We can't really remove these outright for compatibility reasons, so we'll just modify their values. */
        public static string ProfileSettingsPath => Path.Combine(s_applicationPath, $"Configs/{ProfilesLibrary.ProfileName}");
        public static string GlobalSettingsPath => Path.Combine(s_applicationPath, "Configs");

        public static IEditorWindow EditorWindow => Application.Current.MainWindow as IEditorWindow;
    }
}
