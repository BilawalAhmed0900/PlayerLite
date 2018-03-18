using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace PlayerLite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            Mutex mutex = new System.Threading.Mutex(true, 
                @"Global\" + "{9408310947-9450348902375-9735}", out createdNew);
            if (!createdNew)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            GC.KeepAlive(mutex);
        }
    }
}
