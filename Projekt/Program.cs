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

            

            //Instanzieren von den benötigten Objekten und übergaben an die Presenter
            IView mainView = new MainView();            
            MainModel mainModel = new MainModel();
            ConfigView configView = new ConfigView();
            ConfigModel model = new ConfigModel();
            ConfigPresenter configPresenter = new ConfigPresenter(configView, model);
            MainPresenter mainpresenter = new MainPresenter(mainView,mainModel,configPresenter);

            // Die mainView wird angezeigt
            mainpresenter.Initialize();
           
            Application.Run();
            
        }
    }
}
