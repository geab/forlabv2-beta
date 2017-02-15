using System;
using System.Windows.Forms;
using LQT.Core.UserExceptions;

namespace LQT.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

               Application.DoEvents();
                new frmSplash().ShowDialog();                
                Application.Run(new LqtMainWindowForm());
            //}
            //catch (Exception ex)
            //{
            //    new FrmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            //    //System.Diagnostics.Debugger.Break();
            //}
        }
    }
}
