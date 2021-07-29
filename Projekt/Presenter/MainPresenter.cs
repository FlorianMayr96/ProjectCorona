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


        public MainPresenter(IView view, MainModel mainModel, ConfigPresenter configPresenter)
        {
            _view = view;
            _mainModel = mainModel;
            _configPresenter = configPresenter;

            _view.ShowConfigView += ShowConfigView;
            _view.SwitchChart += _view_SwitchChart;
           
            _mainModel.UpdateView += UpdateView;
            
        }

        private void _view_SwitchChart(object sender, string e)
        {
            _mainModel.ChangeChart(sender,e);
        }

        private void UpdateView(object sender, List<List<string[]>> data)
        {
            
            _view.UpdateChart(data);
        }


        private void ShowConfigView(object sender, EventArgs e)
        {
            //_configPresenter.Methodenaufruf showConfigView

        }




    }
}
