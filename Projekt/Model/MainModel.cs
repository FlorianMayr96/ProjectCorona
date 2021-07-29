using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projekt
{
    public class MainModel
    {
        //Event
        public event EventHandler<List<List<Model.AllData>>> UpdateView;
        
        //MemberVariable
        List<List<Model.AllData>> _data = new List<List<Model.AllData>>();

        
        
        /// <summary>
        /// Die in der ConfigView ausgewählten daten werden im MainModel übergeben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public void UpdateList(object sender, List<List<Model.AllData>> data)
        {
            _data = data;
            UpdateView?.Invoke(sender, _data);
        }
        /// <summary>
        /// Es werden die Daten an den Presenter gesendet und anschließend an die MainView wo der Chart aktualisiert angezeigt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="action"></param>
        public void ChangeChart(object sender, string action)
        {
            if (_data.Count == 0)
            {
                MessageBox.Show("Sie müssen ein Bundesland auswählen!");
            }
            else
            {
                UpdateView?.Invoke(sender, _data);
            }
            
        }
    }
}
