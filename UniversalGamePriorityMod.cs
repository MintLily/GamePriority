using MelonLoader;
using System.Diagnostics;

namespace GamePriority;
public class GamePriorityChanger : MelonMod {
    public static class BuildInfo {
        public const string Name = "GamePriority";
        public const string Author = "Lily";
        public const string Company = "Minty Labs";
        public const string Version = "2.0.0";
        public const string DownloadLink = "https://github.com/MintLily/GamePriority";
    }
    
    private MelonPreferences_Category _modCategory;
    private MelonPreferences_Entry<bool> _isSetToHigh;

    private const string ModCategory = "GamePriority";
    private const string SetGamePriority = "SetGamePriorityToHigh";

    public override void OnApplicationStart() {
        _modCategory = MelonPreferences.CreateCategory(ModCategory, "Game Priority");
        _isSetToHigh = _modCategory.CreateEntry(SetGamePriority, false, "Set game priority to high");

        ApplyChanges();
    }

    public override void OnPreferencesSaved() => ApplyChanges();

    private void ApplyChanges() {
        using var p = Process.GetCurrentProcess();
        p.PriorityClass = _isSetToHigh.Value ? ProcessPriorityClass.High : ProcessPriorityClass.Normal;
    }
}