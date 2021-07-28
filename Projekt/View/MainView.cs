using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace Projekt
{
    public partial class MainView : Form,IView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler ShowCovidCases;
        public event EventHandler ShowDeaths;
        public event EventHandler ShowTests;
        public event EventHandler ShowIntensiveStation;
        public event EventHandler ShowRecovered;
        public event EventHandler ShowConfigView;
        public event EventHandler ShowConfirmedCases;

       

        public void UpdateChart(List<List<string[]>> data)
        {

            // Das List Array wird übergeben, es muss noch statt double[] ein Objekt eingesetzt werden!!
            Chart.Series.Clear();
            Chart.AxisX.Clear();
            Chart.AxisY.Clear();

            Chart.LegendLocation = LegendLocation.Right;

            List<string> xAxis = new List<string>();


            // x-Achse

            for (int i = 0; i < data[0][0].Length; i++)
            {
                xAxis.Add(data[0][0][i]);
            }



            Chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {

                Title = "Date",
                Labels = xAxis

            });

            Chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Cases"
            });

            int x = 0;

            foreach (var item in data)
            {
                List<double> yValues = new List<double>();

                for (int i = 0; i < data[x][0].Length; i++)
                {
                    yValues.Add(double.Parse(data[x][0][i]));
                }
                var series = new LineSeries()
                {
                    Title = "OÖ",
                    Values = new ChartValues<double>(yValues),

                };
                Chart.Series.Add(series);
                x++;
            }

        }

        private void btn_CovidCases_Click(object sender, EventArgs e)
        {
            //nur zum Testen!!
            string[] asdf = new string[5];
            asdf[0] = "1";
            asdf[1] = "2";
            asdf[2] = "3";
            asdf[3] = "4";
            asdf[4] = "5";
            List<string[]> OÖ = new List<string[]>();
            OÖ.Add(asdf);
            string[] a = new string[5];
            a[0] = "3";
            a[1] = "4";
            a[2] = "55";
            a[3] = "6";
            a[4] = "7";
            List<string[]> NÖ = new List<string[]>();
            NÖ.Add(a);
            List<List<string[]>> data = new List<List<string[]>>();
            data.Add(OÖ);
            data.Add(NÖ);


            
            ShowCovidCases?.Invoke(sender,e);


        }

        private void btn_Deaths_Click(object sender, EventArgs e)
        {
            ShowDeaths?.Invoke(sender,e);

        }

        private void btn_Tests_Click(object sender, EventArgs e)
        {
            ShowTests?.Invoke(sender, e);
        }

        private void btn_IntensiveStation_Click(object sender, EventArgs e)
        {
            ShowIntensiveStation?.Invoke(sender, e);
        }

        private void btn_Recovered_Click(object sender, EventArgs e)
        {
            ShowRecovered?.Invoke(sender, e);
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            ShowConfigView?.Invoke(sender, e);
        }

        public void updateChart(List<List<string[]>> data)
        {
            throw new NotImplementedException();
        }
    }
}
