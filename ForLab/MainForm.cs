using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ForLab
{
    public partial class MainForm : Form
    {
        private static readonly string LQTEXE = "LQT.GUI.exe";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName(LQTEXE);
            if (procs.Length == 0)
            {
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                path = Path.Combine(path, LQTEXE);
                Process.Start(path);

                Application.Exit();
            }
        }

    }
}
