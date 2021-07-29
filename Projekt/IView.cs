using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public interface IView
    {
        event EventHandler<string> SwitchChart;
        event EventHandler ShowConfigView;

        void UpdateChart(List<List<string[]>> data);
        void Show();

    }
}
