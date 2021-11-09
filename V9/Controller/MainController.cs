using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;
using V9.View;

namespace V9.Controller
{
    public class MainController
    {
        IMainView _view;
        IList<Material> _list;

        public MainController(IMainView view, IList<Material> list)
        {
            _view = view;
            _list = list;
            view.SetController(this);
        }

        public void LoadView()
        {
            foreach (Material item in _list)
            {
                _view.AddMatirial(item);
            }
        }
    }
}
