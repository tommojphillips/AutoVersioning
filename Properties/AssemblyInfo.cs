﻿// VERSION 1.2
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
[assembly: AssemblyVersion("1.2.0.10")]
[assembly: AssemblyFileVersion("1.2.0.10")]

namespace TommoJProductions.AutoVersioningDemo
{

    public class VersionInfo
    {
	    public const string lastestRelease = "06.05.2023 06:46 PM";
	    public const string version = "1.2.0.10";

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
