using MelonLoader;
using System.Diagnostics;

namespace GamePriority
{
    public class GamePriorityChanger : MelonMod
    {
        public static class BuildInfo
        {
            public const string Name = "GamePriority";
            public const string Author = "KortyBoi";
            public const string Company = null;
            public const string Version = "1.1.1";
            public const string DownloadLink = "https://github.com/KortyBoi/GamePriority/";
        }

        private const string ModCategory = "GamePriority";
        private const string setGamePriority = "SetGamePriorityToHigh";

        public override void OnApplicationStart()
        {
            MelonPrefs.RegisterCategory(ModCategory, "Game Priority");
            MelonPrefs.RegisterBool(ModCategory, setGamePriority, false, "Set game priority to High");

            ApplyChanges();
        }

        public override void OnModSettingsApplied()
        {
            ApplyChanges();
        }

        private static void ApplyChanges()
        {
            bool highPriority = MelonPrefs.GetBool(ModCategory, setGamePriority);
            if (!highPriority)
            {
                using (Process p = Process.GetCurrentProcess())
                    p.PriorityClass = ProcessPriorityClass.Normal;
                MelonLogger.Log($"Set game's process priority to: Normal");
            }
            else if (highPriority)
            {
                using (Process p = Process.GetCurrentProcess())
                    p.PriorityClass = ProcessPriorityClass.High;
                MelonLogger.Log($"Set game's process priority to: High");
            }
        }
    }
}