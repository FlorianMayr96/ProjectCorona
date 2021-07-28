using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public interface IView
    {
        event EventHandler ShowConfirmedCases;
        event EventHandler ShowDeaths;
        event EventHandler ShowTests;
        event EventHandler ShowIntensiveStation;
        event EventHandler ShowRecovered;
        event EventHandler ShowConfigView;

        void updateChart();

    }
}
