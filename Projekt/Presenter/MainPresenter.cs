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
            _view.ShowConfirmedCases += ShowCovidCases;
            _view.ShowDeaths += ShowDeaths;
            _view.ShowIntensiveStation += ShowIntensivstation;
            _view.ShowRecovered += ShowRecovered;
            _view.ShowTests += ShowTests;
            _mainModel.UpdateView += UpdateView;
            
        }

        private void UpdateView(object sender, List<List<string[]>> data)
        {
            
            _view.UpdateChart(data);
        }

        private void ShowTests(object sender, EventArgs e)
        {
            _mainModel.ChangeChart(sender,"Tests");
        }

        private void ShowRecovered(object sender, EventArgs e)
        {
            _mainModel.ChangeChart(sender, "Recovered");
        }

        private void ShowIntensivstation(object sender, EventArgs e)
        {
            _mainModel.ChangeChart(sender, "IntensiveStation");
        }

        private void ShowDeaths(object sender, EventArgs e)
        {
            _mainModel.ChangeChart(sender, "Deaths");
        }

        private void ShowCovidCases(object sender, EventArgs e)
        {
            _mainModel.ChangeChart(sender, "CovidCases");
        }

        private void ShowConfigView(object sender, EventArgs e)
        {
            //_configPresenter.Methodenaufruf showConfigView
            

        }




    }
}
