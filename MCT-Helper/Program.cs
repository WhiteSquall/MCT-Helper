using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCT_Helper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isNew;
            Mutex mutex = new Mutex(true, "itSign", out isNew);

            if (isNew)
            {
                Application.Run(new fMainMenu());
                mutex.ReleaseMutex();
            }
        }
    }
}
