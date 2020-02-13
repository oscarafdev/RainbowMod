namespace Fougerite
{
    using System.IO;
    using System.Text.RegularExpressions;
    using UnityEngine;

    public static class Config
    {
        private static IniParser fougeriteDirectoryConfig;
        private static IniParser fougeriteConfig;

        public static IniParser FougeriteDirectoryConfig { get => fougeriteDirectoryConfig; set => fougeriteDirectoryConfig = value; }
        public static IniParser FougeriteConfig { get => fougeriteConfig; set => fougeriteConfig = value; }

        public static void Init(string DirectoryConfigPath)
        {
            if (File.Exists(DirectoryConfigPath))
            {
                FougeriteDirectoryConfig = new IniParser(DirectoryConfigPath);
                Debug.Log($"El archivo de configuracion {DirectoryConfigPath} fue cargado con exito.");
            }
            else Debug.Log($"El archivo de configuracion {DirectoryConfigPath} FALLO AL CARGAR.");

            string ConfigPath = Path.Combine(GetPublicFolder(), "Fougerite.cfg");

            if (File.Exists(ConfigPath))
            {
                FougeriteConfig = new IniParser(ConfigPath);
                Debug.Log(string.Format("Configuracion {0} cargada.", ConfigPath));
            }
            else Debug.Log(string.Format("Configuracion {0} NO CARGADA.", ConfigPath));
        }

        public static string GetValue(string Section, string Setting)
        {
            return FougeriteConfig.GetSetting(Section, Setting);
        }

        public static bool GetBoolValue(string Section, string Setting)
        {
            return FougeriteConfig.GetBoolSetting(Section, Setting);
        }

        public static string GetModulesFolder()
        {
            Regex root = new Regex(@"^%RootFolder%", RegexOptions.IgnoreCase);             
            string path = root.Replace(FougeriteDirectoryConfig.GetSetting("Settings", "ModulesFolder"), Util.GetRootFolder()) + @"\";
            return Util.NormalizePath(path);
        }

        public static string GetPluginsFolder()
        {
            string path = $"{Util.GetRootFolder()}\\Gamemode\\Plugins";
            return Util.NormalizePath(path);
        }

        public static string GetPublicFolder()
        {
            Regex root = new Regex(@"^%RootFolder%", RegexOptions.IgnoreCase);             
            string path = root.Replace(FougeriteDirectoryConfig.GetSetting("Settings", "PublicFolder"), Util.GetRootFolder()) + @"\";
            return Util.NormalizePath(path);
        }
    }
}
