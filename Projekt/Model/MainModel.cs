using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class MainModel
    {
        public event EventHandler<List<List<string[]>>> UpdateView;
        public event EventHandler<List<List<double>>> ChangeView;

        List<List<string[]>> _data = new List<List<string[]>>();
        

        public void UpdateList(object sender, List<List<string[]>> data)
        {
            _data = data;
            UpdateView?.Invoke(sender, data);
        }

        public void ChangeChart(object sender, string action)
        {
            
            switch (action)
            {
                case "covidCases":
                    //foreach (var item in _data[0])
                    //{
                    
                    //}
                break;

                case "Deaths":
                
                break;

                case "Tests":

                break;

                case "IntensiveStation":

                break;

                case "Recovered":

                break;

                default:
                    break;
            }
        }
    }
}
