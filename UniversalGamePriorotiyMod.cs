using MelonLoader;
using System.Diagnostics;

namespace GamePriority
{
    public class HighPriority : MelonMod
    {
        public static class BuildInfo
        {
            public const string Name = "Game Priority Changer";
            public const string Author = "KortyBoi";
            public const string Company = null;
            public const string Version = "1.0.0";
            public const string DownloadLink = null;
        }

        private const string ModCategory = "GamePriority";
        private const string setGamePriority = "SetGamePriorityToHigh";

        public override void OnApplicationStart()
        {
            ModPrefs.RegisterCategory(ModCategory, "Game Priority");
            ModPrefs.RegisterPrefBool(ModCategory, setGamePriority, false, "Set game priority to High");

            ApplyChanges();
        }

        public override void OnModSettingsApplied()
        {
            ApplyChanges();
        }

        private static void ApplyChanges()
        {
            bool highPriority = ModPrefs.GetBool(ModCategory, setGamePriority);
            if (!highPriority)
            {
                using (Process p = Process.GetCurrentProcess())
                    p.PriorityClass = ProcessPriorityClass.Normal;
                MelonModLogger.Log($"Set game's process priority to: Normal");
            }
            else if (highPriority)
            {
                using (Process p = Process.GetCurrentProcess())
                    p.PriorityClass = ProcessPriorityClass.High;
                MelonModLogger.Log($"Set game's process priority to: High");
            }
        }
    }
}