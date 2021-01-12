﻿using H3VRModInstaller.Common;
using H3VRModInstaller.JSON.Common;

namespace H3VRModInstaller.GUI
{
    /// <summary>
    ///     Common fields for the GUI
    /// </summary>
    public class GUICommon
    {
        public string SelectedModText = "Selected Mod: ";

        public ModListFile[] MapModList(ModListFile[] output)
        {
            var input = JsonCommon.GetAllMods();

            output = new ModListFile[JsonCommon.JsonFiles.Length];

            for (var i = 0; i <= JsonCommon.JsonFiles.Length; i++)
            {
                input[i].Name = output[i].Name;
                input[i].Version = output[i].Version;
                input[i].Dependencies = output[i].Dependencies;
            }

            return output;
        }

        public struct Files
        {
            public static string EXEPath = ModInstallerCommon.Files.MainFiledir + @"\h3vr.exe";
            public static string EnabledName = @"/winhttp.dll";
            public static string DisabledName = @"/WinHTTP.dll.DISABLED";
        }


        public class ModListFile
        {
            public string Name { get; set; }
            public string Version { get; set; }
            public string[] Dependencies { get; set; }
        }
    }
}