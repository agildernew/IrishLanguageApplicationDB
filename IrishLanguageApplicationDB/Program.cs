using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrishLanguageApplicationDB
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
            //Application.Run(new MainForm("agildernew", "Admin"));
            //Application.Run(new LoginForm());
            Application.Run(new MultipleChoiceForm("Colours"));

        }
    }
}