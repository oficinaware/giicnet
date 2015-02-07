using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI
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

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-PT");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-PT");

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Base.Acessos.login());
        }
    }
}
