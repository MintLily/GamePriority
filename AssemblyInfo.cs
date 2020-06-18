using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using GamePriority;

[assembly: AssemblyTitle(HighPriority.BuildInfo.Name)]
[assembly: AssemblyDescription("Using MelonLoader, this is a universal mod that allows you to set the game's process priority with either Normal or High")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(HighPriority.BuildInfo.Company)]
[assembly: AssemblyProduct(HighPriority.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + HighPriority.BuildInfo.Author)]
[assembly: AssemblyTrademark(HighPriority.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: Guid("76A74B7D-000B-42AC-8F48-60E5D449CA91")]
[assembly: AssemblyVersion(HighPriority.BuildInfo.Version)]
[assembly: AssemblyFileVersion(HighPriority.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(HighPriority), HighPriority.BuildInfo.Name, HighPriority.BuildInfo.Version, HighPriority.BuildInfo.Author, HighPriority.BuildInfo.DownloadLink)]
[assembly: MelonModGame]