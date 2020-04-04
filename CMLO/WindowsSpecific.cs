using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMLO
{
    public static class WindowsSpecific
    {
        // Important: Add reference 'Windows Script Host Object Mode'

        // Source: Code Ripped from
        // https://www.fluxbytes.com/csharp/create-shortcut-programmatically-in-c/
        // Call with:
        //CreateShortcut("my shortcut", path, Assembly.GetExecutingAssembly().Location);
        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "My shortcut description";   // The description of the shortcut
            shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;           // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

        //My Version of createshortcut to add to startup
        public static void addToStartup(string shortcutName, string targetFileLocation)
        {
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup\";
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "This enables the autostart on startup";   // The description of the shortcut
            //shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;           // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }
        public static void removeFromStartup(string shortcutName)
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup\";
            System.IO.File.Delete(startupPath + shortcutName + ".lnk");
        }
        public static bool checkForStartup(string shortcutName)
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup\";
            return System.IO.File.Exists(startupPath + shortcutName + ".lnk");
        }
    }
}
