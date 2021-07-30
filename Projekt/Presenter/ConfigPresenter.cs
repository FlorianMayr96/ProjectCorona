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
        /// <summary>
        /// initialisierung der view und vom model und beschreiben der Events
        /// </summary>
        /// <param name="configView"></param>
        /// <param name="model"></param>
        public ConfigPresenter(ConfigView configView, ConfigModel model)
        {
            _configView = configView;
            configView.addCountry += addCountry;
            configView.Import += import;
            configView.closeView += close;
            configView.refresh += refresh;
            _model = model;
        }
        /// <summary>
        /// eventmethode für die Übergabe zum mainpresenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void import(object sender, List<string> e)
        {
            dataForMain = _model.findListForExport(e);
            exportToMain?.Invoke(this, dataForMain);
        }
        /// <summary>
        /// eventmethode für aktualisieren. Hier werden alle daten gefiltert und gespeichert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

       /* private void deleteCountry(object sender, int e)
        {
            throw new NotImplementedException();
        }*/

        /// <summary>
        /// eventmethode für verstecken der View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, EventArgs e)
        {
            _configView.Hide();
        }


        /// <summary>
        /// Hinzufügen von einenm Eingegebenen Bundesland zur ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void addCountry(object sender, string e)
        {

            // Überprüfung von Existenz in den Daten und vorhandensein in der Listview
            if (_model.existence(e) == true && _configView.AproveExistInListView(e) == false)
            {
                _configView.UpdateText(e);
            }
            else
            {
                if (_model.existence(e) == false)
                {
                    // Öffnet Fehlerfenster
                    _configView.notExistsMessage();
                }
            }



        }
        /// <summary>
        /// Methode für Öffnen der View
        /// </summary>
        public void openView()
        {
            _configView.Show();
        }
        /// <summary>
        /// für testzwecke
        /// </summary>
        public void InitializeConfig()
        {
            _configView.Show();
        }
    }
}
