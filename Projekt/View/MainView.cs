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
        //memberVariable. 
        //Beim klicken eines Buttens wird diese Variable überschrieben, 
        //damit die Methode "UpdateChart"weiß was der Benutzer angeklickt hat um die richtigen daten aus der Liste zu filtern.
        string ChartCase;

        
        public MainView()
        {
            InitializeComponent();
        }
        
        //Events
        public event EventHandler<string> SwitchChart;
        public event EventHandler ShowConfigView;

    
        /// <summary>
        /// Es wird eine Liste mit den ausgewählten Bundesländern übergeben und dann in der MainView in dem Chart angezeigt
        /// </summary>
        /// <param Liste mit den ausgewählten Bundesländern ="data"></param>
        public void UpdateChart(List<List<Model.AllData>> data)
        {
            //löscht den angezeigten Chart
            Chart.Series.Clear();
            Chart.AxisX.Clear();
            Chart.AxisY.Clear();

            //die Legende wird rechts Platziert
            Chart.LegendLocation = LegendLocation.Right;

            // es wird die x - Achse gezeichnet
            List<string> xAxis = new List<string>();
            int j = 0;
            foreach (var item in data[0])
            {
                string[] temp = data[0][j].date.ToString().Split(' ');
                xAxis.Add(temp[0]);
                j++;
            }

            Chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {

                Title = "Date",
                Labels = xAxis

            });


            //Die y-Achse wird gezeichnet
            Chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = ChartCase
            });

            int x = 0;
            foreach (var item in data)
            {
                List<double> yValues = new List<double>();

                switch (ChartCase)
                {
                    case "CovidCases":
                        foreach (var cases in data[x])
                        {
                            yValues.Add(cases.confirmedCases);
                        }
                        break;

                    case "Deaths":
                        foreach (var cases in data[x])
                        {
                            yValues.Add(cases.deaths);
                        }
                        break;

                    case "Tests":
                        foreach (var cases in data[x])
                        {
                            yValues.Add(cases.tests);
                        }
                        break;

                    case "IntensiveStation":
                        foreach (var cases in data[x])
                        {
                            yValues.Add(cases.intensiveCareUnit);
                        }
                        break;

                    case "Recovered":
                        foreach (var cases in data[x])
                        {
                            yValues.Add(cases.recoverd);
                        }
                        break;

                    default:
                        break;
                }

                var series = new LineSeries()
                {
                    Title = data[x][0].country,
                    Values = new ChartValues<double>(yValues),

                };
                Chart.Series.Add(series);
                x++;
            }

    }

       
        //BtnClick Coronafälle
        private void btn_CovidCases_Click(object sender, EventArgs e)
        {
            ChartCase = "CovidCases";
            SwitchChart?.Invoke(sender,"CovidCases");  
        }

        // BtnClick CoronaTote
        private void btn_Deaths_Click(object sender, EventArgs e)
        {
            ChartCase = "Deaths";
            SwitchChart?.Invoke(sender, "Deaths");
            
        }

        // BtnClick Tests

        private void btn_Tests_Click(object sender, EventArgs e)
        {
            ChartCase = "Tests";
            SwitchChart?.Invoke(sender, "Tests");
        }
  
        // BtnClick IntensiveStation

        private void btn_IntensiveStation_Click(object sender, EventArgs e)
        {
            ChartCase = "IntensiveStation";
            SwitchChart?.Invoke(sender, "IntensiveStation");
        }

        //BtnClick Genesene Personen


        private void btn_Recovered_Click(object sender, EventArgs e)
        {
            ChartCase = "Recovered";
            SwitchChart?.Invoke(sender, "Recovered");
        }

        // BtnClick aufruf der ConfigView

        private void btn_Config_Click(object sender, EventArgs e)
        {

            ShowConfigView?.Invoke(sender,e);
        }

        
    }
}
