using System.IO;
using System.Diagnostics;
using LitJson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncherLibrary
{
    public class Launcher
    {
        public static void PlayGame()
        {
            Process.Start(Directory.GetCurrentDirectory() + "/Game.exe");
        }

        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }
}
