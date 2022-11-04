using System;
using MelonLoader;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GamePriority;
public class GamePriorityChanger : MelonMod {
    public static class BuildInfo {
        public const string Name = "GamePriority";
        public const string Author = "Lily";
        public const string Company = "Minty Labs";
        public const string Version = "2.0.1";
        public const string DownloadLink = "https://github.com/MintLily/GamePriority";
    }
    
    private MelonPreferences_Category _modCategory;
    private MelonPreferences_Entry<bool> _isSetToHigh;

    private const string ModCategory = "GamePriority";
    private const string SetGamePriority = "SetGamePriorityToHigh";

    private int _failedProcessPriorityChange;

    public override void OnApplicationStart() {
        _modCategory = MelonPreferences.CreateCategory(ModCategory, "Game Priority");
        _isSetToHigh = _modCategory.CreateEntry(SetGamePriority, false, "Set game priority to high");

        ApplyChanges();
    }

    private void ApplyChanges() => Task.Run(async () => await DelayedRun());

    private async Task DelayedRun() {
        await Task.Delay(5000);
        try {
            using var p = Process.GetCurrentProcess();
            p.PriorityClass = _isSetToHigh.Value ? ProcessPriorityClass.High : ProcessPriorityClass.Normal;
        }
        catch (Exception e) {
            MelonLogger.Error($"Failed to change ProcessPriority, retying ...\nEXCEPTION:\n{e}\nSTACK TRACE:\n{e.StackTrace}");
            if (_failedProcessPriorityChange >= 5)
                return;
            ApplyChanges();
            _failedProcessPriorityChange += 1;
        }
    }
}