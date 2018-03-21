using System;
using System.Reflection;
using Harmony;

namespace QPrawnToggleGrapple
{
    internal class QPatch
    {
        public static void Patch()
        {
            HarmonyInstance harmonyInstance = HarmonyInstance.Create("qprawn_toggle_grapple.mod");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
            QPatch.Path = (QPatch.Path ?? "QMods\\QPrawnToggleGrapple");
            QPatch.LoadConfig();
            Console.WriteLine("[QPrawnToggleGrapple] Patched");
        }

        private static string GetModInfoPath()
        {
            return Environment.CurrentDirectory + "\\" + QPatch.Path + "\\mod.json";
        }

        private static void LoadConfig()
        {
        }

        private static string Path = null;
    }
}
