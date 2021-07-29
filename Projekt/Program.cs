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


            IView mainView = new MainView();
            MainModel mainModel = new MainModel();
            ConfigPresenter configPresenter = new ConfigPresenter();


            MainPresenter mainpresenter = new MainPresenter(mainView,mainModel,configPresenter);


            Application.Run(new MainView());
        }
    }
}
