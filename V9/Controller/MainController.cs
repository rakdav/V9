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
        private IMainView _view;
        private IList<Material> _list;
        private int count;
        public MainController(IMainView view, IList<Material> list)
        {
            _view = view;
            _list = list;
            view.SetController(this);
            if(list.Count%15==0)
            {
                count = list.Count / 15;
            }
            else
            {
                count = (list.Count / 15) + 1;
            }
        }

        public void AddPagination()
        {
            for (int i = 1; i <= count; i++)
                _view.AddPage(i);
        }
        public void LoadView()
        {
            //foreach (Material item in _list)
            //{
            //    _view.AddMatirial(item);
            //}
            LoadView(1);
        }
        public void LoadView(int n)
        {
            _view.Clear();
            for(int i=(n-1)*15;i<n*15;i++)
            {
                if(i<_list.Count-1)
                    _view.AddMatirial(_list[i]);
            }
        }
    }
}
