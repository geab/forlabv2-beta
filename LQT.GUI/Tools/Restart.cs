using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LQT.GUI.Tools
{
    public class Restart
    {
        private const string RESTARTER = "ForLab.exe";

        /// <summary>
        /// Launches the application restarter.<br/>
        /// </summary>
        public static void LaunchRestarter()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            path = Path.Combine(path, RESTARTER);
            Process.Start(path);

            Application.Exit();
        }
    }
}
