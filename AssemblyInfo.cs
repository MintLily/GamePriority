using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using GamePriority;

[assembly: AssemblyTitle(GamePriorityChanger.BuildInfo.Name)]
[assembly: AssemblyDescription("Using MelonLoader, this is a universal mod that allows you to set the game's process priority with either Normal or High")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(GamePriorityChanger.BuildInfo.Company)]
[assembly: AssemblyProduct(GamePriorityChanger.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + GamePriorityChanger.BuildInfo.Author)]
[assembly: AssemblyTrademark(GamePriorityChanger.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: Guid("76A74B7D-000B-42AC-8F48-60E5D449CA91")]
[assembly: AssemblyVersion(GamePriorityChanger.BuildInfo.Version)]
[assembly: AssemblyFileVersion(GamePriorityChanger.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(GamePriorityChanger), GamePriorityChanger.BuildInfo.Name, GamePriorityChanger.BuildInfo.Version, GamePriorityChanger.BuildInfo.Author, GamePriorityChanger.BuildInfo.DownloadLink)]
[assembly: MelonGame]