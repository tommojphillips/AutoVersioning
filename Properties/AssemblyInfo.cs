// VERSION 1.3
using System.Reflection;
using System.Resources;

// General Information
[assembly: AssemblyTitle("AutoVersioningDemo")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Tommo J. Productions")]
[assembly: AssemblyProduct("AutoVersioningDemo")]
[assembly: AssemblyCopyright("Tommo J. Productions Copyright © 2023")]
[assembly: NeutralResourcesLanguage("en-AU")]

// Version information
[assembly: AssemblyVersion("1.3.0.20")]
[assembly: AssemblyFileVersion("1.3.0.20")]

namespace TommoJProductions.AutoVersioningDemo
{
    
    /// <summary>
    /// Represents the version info for AutoVersioningDemo
    /// </summary>
    public class VersionInfo
    {
        /// <summary>
        /// Represents latest release version date. Format: dd:MM:yyyy hh:mm tt
        /// </summary>
	    public const string lastestRelease = "14.07.2023 06:58 PM";
        /// <summary>
        /// Represents current version.
        /// </summary>
	    public const string version = "1.3.0.20";

        /// <summary>
        /// Represents if the mod has been complied for x64
        /// </summary>
        #if x64
            internal const bool IS_64_BIT = true;
        #else
            internal const bool IS_64_BIT = false;
        #endif
        /// <summary>
        /// Represents if the mod has been complied in Debug mode
        /// </summary>
        #if DEBUG
            internal const bool IS_DEBUG_CONFIG = true;
        #else
            internal const bool IS_DEBUG_CONFIG = false;
        #endif
    }
}
