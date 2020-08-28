using CO435_WinFormsAnswer.App07;
using System;
using System.Windows.Forms;

namespace CO435_WinFormsAnswer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SimulatorForm());
        }
    }
}
