using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApplication
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
            //Application.Run(new Prompt());
            //Application.Run(new SettingsForm());
            //Application.Run(new HomeForm());
            Application.Run(new MdiForm());
            //Application.Run(new SettingsForm());
        }
    }
}
