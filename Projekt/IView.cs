using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public interface IView
    {
        //Events
        event EventHandler<string> SwitchChart;
        event EventHandler ShowConfigView;

        //Der Chartverlauf wird in der MainView gezeichnet
        void UpdateChart(List<List<Model.AllData>> data);

        //Es wird die MainView angezeigt
        void Show();

    }
}
