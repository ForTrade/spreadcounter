using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace SpreadCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isFirstInstance;
            using (Mutex objMutex = new Mutex(false, "Local\\" + "SpreadCounter", out isFirstInstance))
            {
                if (!isFirstInstance)
                {
                    MessageBox.Show("Spread Counter Pro is already running", "Single Use Only", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new SpreadCounter());
                }
            }
        }
    }
}
