using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
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

            ConfigView configView = new ConfigView();
            ConfigModel model = new ConfigModel();
            ConfigPresenter configPresenter = new ConfigPresenter(configView, model);
            //Nur zu Testzwecken
            configPresenter.InitializeConfig();
            Application.Run();
        }
    }
}
