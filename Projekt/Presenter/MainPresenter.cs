using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class MainPresenter
    {
        IView _view;
        MainModel _mainModel;
        ConfigPresenter _configPresenter;

        /// <summary>
        /// Construktor
        /// </summary>
        /// <param mainView="view"></param>
        /// <param werden die daten der Ausgewählten Budesländer gespeichert="mainModel"></param>
        /// <param name="configPresenter"></param>
        public MainPresenter(IView view, MainModel mainModel, ConfigPresenter configPresenter)
        {
            _view = view;
            _mainModel = mainModel;
            _configPresenter = configPresenter;
            _view.ShowConfigView += ShowConfigView;
            
            _view.SwitchChart += _view_SwitchChart;
           
            _mainModel.UpdateView += UpdateView;
            _configPresenter.exportToMain += ExportToMain;
        }
        /// <summary>
        /// Die ausgewählten Daten der ConfigView werden aufbereitet an das mainModel gesendet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToMain(object sender, List<List<Model.AllData>> e)
        {
            _mainModel.UpdateList(this,e);
        }
        /// <summary>
        /// Die mainView wird Angezeigt
        /// </summary>
        public void Initialize()
        {
            _view.Show();
        }
        /// <summary>
        /// Die ConfigView wird angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowConfigView(object sender, EventArgs e)
        {
            _configPresenter.openView();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _view_SwitchChart(object sender, string e)
        {

            _mainModel.ChangeChart(sender, e);
        }
        /// <summary>
        /// Die data Liste wird an die mainView gesendet,und im Chart angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void UpdateView(object sender, List<List<Model.AllData>> data)
        {
            
            _view.UpdateChart(data);

        }


     
        




    }
}
