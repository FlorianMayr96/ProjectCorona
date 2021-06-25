using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class ConfigView : Form
    {
        public event EventHandler<string> addCountry;
        public event EventHandler<int> deleteCountry;
        public event EventHandler Import;
        public event EventHandler closeView;
        public ConfigView()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
          
            addCountry?.Invoke(this, tbCountryInput.Text);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewCountries.SelectedIndices.Count > 0)
            {
                int index = listViewCountries.SelectedIndices[0];
                deleteCountry?.Invoke(this, index);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import?.Invoke(this, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeView?.Invoke(this, e);
        }
    }
}
