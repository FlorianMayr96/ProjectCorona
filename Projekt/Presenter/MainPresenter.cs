using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class MainPresenter
    {
        IView _view;
        MainModel _mainModel;
        ConfigPresenter _configPresenter;


        public MainPresenter(IView view, MainModel mainModel, ConfigPresenter configPresenter)
        {
            _view = view;
            _mainModel = mainModel;
            _configPresenter = configPresenter;

        }




    }
}
