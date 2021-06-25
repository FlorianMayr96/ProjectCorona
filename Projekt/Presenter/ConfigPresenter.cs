using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ConfigPresenter
    {
        private ConfigView _configView;
        public event EventHandler importData;
        public ConfigPresenter(ConfigView configView)
        {
            _configView = configView;
            configView.addCountry += addCountry;
            configView.deleteCountry += deleteCountry;
            configView.Import += import;
            configView.closeView += close;

        }

        private void deleteCountry(object sender, int e)
        {
            throw new NotImplementedException();
        }

        private void close(object sender, EventArgs e)
        {
            _configView.Hide();
        }

        private void import(object sender, EventArgs e)
        {
            
        }

        private void addCountry(object sender, string e)
        {
            throw new NotImplementedException();
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
