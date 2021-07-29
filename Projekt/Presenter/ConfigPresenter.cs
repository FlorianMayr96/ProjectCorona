using Projekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class ConfigPresenter
    {

        List<List<AllData>> dataForMain;
        private ConfigView _configView;
        downloader downloader = new downloader();
        private ConfigModel _model;
        public event EventHandler<List<List<AllData>>> exportToMain;
        public ConfigPresenter(ConfigView configView, ConfigModel model)
        {
            _configView = configView;
            configView.addCountry += addCountry;
            configView.deleteCountry += deleteCountry;
            configView.Import += import;
            configView.closeView += close;
            configView.refresh += refresh;
            _model = model;
        }

        private void import(object sender, List<string> e)
        {
            dataForMain = _model.findListForExport(e);
            exportToMain?.Invoke(this, dataForMain);
        }

        private void refresh(object sender, string e)
        {
            int i = 0;
            string[] allData = downloader.LoadData(e);

            _model.Clear();
            // Split the input data
            foreach (var item in allData)
            {
                string[] temp = downloader.Split(allData, i);
                if (i != 0)
                {
                    AllData all = new AllData(temp);
                    _model.organizeAndSafe(all);
                }
                i++;
            }
        }

        private void deleteCountry(object sender, int e)
        {
            throw new NotImplementedException();
        }

        private void close(object sender, EventArgs e)
        {
            _configView.Hide();
        }




        private void addCountry(object sender, string e)
        {


            if (_model.existence(e) == true && _configView.AproveExistInListView(e) == false)
            {
                _configView.UpdateText(e);
            }
            else
            {
                if (_model.existence(e) == false)
                {

                    _configView.notExistsMessage();
                }
            }



        }

        public void openView()
        {
            _configView.Show();
        }
        public void InitializeConfig()
        {
            _configView.Show();
        }
    }
}
