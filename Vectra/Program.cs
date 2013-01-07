using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Vectra
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_MAXSIZE = 3;

        static bool ActivateApplicationAlreadyRunning()
        {
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(proc);
            //MessageBox.Show(processes.Length.ToString());
            if (processes.Length < 2) return (false);
            foreach (Process process in processes)
            {
                if (process.Id != Process.GetCurrentProcess().Id)
                {
                    SetForegroundWindow(process.MainWindowHandle);
                    ShowWindow(process.MainWindowHandle, SW_MAXSIZE);
                    return (true);
                }
            }
            return (true);
        }



        [STAThread]
        static void Main()
        {
            if (ActivateApplicationAlreadyRunning()) return;
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Frame());
            }
            catch (Exception ex)
            {
                DialogResult result = BetterDialog.ShowDialog("Vectra", "Unhandled Exception - Contact Developer", ex.Message, "Show Developer Details", "Close", Properties.Resources.books.ToBitmap());
                if (result == DialogResult.OK)
                {
                    Form f = new ExceptionForm(ex);
                    f.ShowDialog();
                }
            }
        }
    }
}
