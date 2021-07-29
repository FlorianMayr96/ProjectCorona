using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt
{
    public partial class ConfigView : Form
    {
        const string B = "Burgenland";
        const string K = "Kärnten";
        const string N = "Niederösterreich";
        const string O = "Oberösterreich";
        const string S = "Salzburg";
        const string T = "Tirol";
        const string V = "Vorarlberg";
        const string ST = "Steiermark";
        const string W = "Wien";
        const string AT = "Österreich";
        const string path = "timeline-faelle-bundeslaender.csv";

        bool refreshStatus = false;
        List<string> importedCountries;
        public event EventHandler<string> addCountry;
        public event EventHandler<int> deleteCountry;
        public event EventHandler<List<string>> Import;
        public event EventHandler closeView;
        public event EventHandler<string> refresh;
        public ConfigView()
        {
            InitializeComponent();
            importedCountries = new List<string>();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {

            if (refreshStatus == true)
            {
                addCountry?.Invoke(this, tbCountryInput.Text);
            }
            else
            {
                MessageBox.Show("Keine Daten Vorhanden bitte aktualisieren Sie die Daten", "Info", MessageBoxButtons.OK);
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewCountries.SelectedIndices.Count > 0)
            {
                int index = listViewCountries.SelectedIndices[0];
                listViewCountries.Items.RemoveAt(index);

            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
            ListViewItem text = new ListViewItem();
            text = listViewCountries.FindItemWithText(B);

            if (text != null)
            {
                if (text.Text == B)
                {
                    importedCountries.Add(B);
                }
            }
            text = listViewCountries.FindItemWithText(N);

            if (text != null)
            {
                if (text.Text == N)
                {
                    importedCountries.Add(N);
                }
            }
            text = listViewCountries.FindItemWithText(O);

            if (text != null)
            {
                if (text.Text == O)
                {
                    importedCountries.Add(O);
                }
            }
            text = listViewCountries.FindItemWithText(S);

            if (text != null)
            {
                if (text.Text == S)
                {
                    importedCountries.Add(S);
                }
            }
            text = listViewCountries.FindItemWithText(T);

            if (text != null)
            {
                if (text.Text == T)
                {
                    importedCountries.Add(T);
                }
            }
            text = listViewCountries.FindItemWithText(V);

            if (text != null)
            {
                if (text.Text == V)
                {
                    importedCountries.Add(V);
                }
            }
            text = listViewCountries.FindItemWithText(K);

            if (text != null)
            {
                if (text.Text == K)
                {
                    importedCountries.Add(K);
                }
            }
            text = listViewCountries.FindItemWithText(ST);

            if (text != null)
            {
                if (text.Text == ST)
                {
                    importedCountries.Add(ST);
                }
            }
            text = listViewCountries.FindItemWithText(W);

            if (text != null)
            {
                if (text.Text == W)
                {
                    importedCountries.Add(W);
                }
            }
            text = listViewCountries.FindItemWithText(AT);

            if (text != null)
            {
                if (text.Text == AT)
                {
                    importedCountries.Add(AT);
                }
            }

            Import?.Invoke(this, importedCountries);
            importedCountries.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeView?.Invoke(this, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (File.Exists(path) == true)
            {
                refreshStatus = true;
                refresh?.Invoke(this, path);
            }
            else
            {
                MessageBox.Show("Kein gültiger Dateipfad. Die Datei Soll sich im Debug Ordner befinden!", "Info", MessageBoxButtons.OK);
            }
            
        }
        public void notExistsMessage()
        {
            MessageBox.Show("Kein gültiges Land", "Info", MessageBoxButtons.OK);
        }
        internal void UpdateText(string country)
        {
            
                var row = new string[] { country };
                var lvi = new ListViewItem(row);


                listViewCountries.Items.Add(lvi);
           
        }
        internal bool AproveExistInListView(string country)
        {
            bool a = false;

            ListViewItem text = new ListViewItem();
            text = listViewCountries.FindItemWithText(country);

            if (text != null)
            {
                if (text.Text == country)
                {
                    a = true;
                }
            }
            return a;

        }
        
    }
}
