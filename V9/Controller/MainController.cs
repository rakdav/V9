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
            for (int i = 0; i <= count+1; i++)
            {
                if (i == 0) _view.AddLeftRight("<");
                else if(i==count+1) _view.AddLeftRight(">");
                else _view.AddPage(i);
            }
        }
        public int getCount()
        {
            return count;
        }
        public void SortByName()
        {
            _list=_list.OrderBy(u => u.Title).ToList();
        }
        public void SortByNameDesc()
        {
            _list = _list.OrderByDescending(u => u.Title).ToList();
        }
        public void SortByAmount()
        {
            _list=_list.OrderBy(u => u.CountInStock).ToList();
        }

        public void SortByAmountDesc()
        {
            _list = _list.OrderByDescending(u => u.CountInStock).ToList();
        }
        public void SortByCost()
        {
            _list = _list.OrderBy(u => u.Cost).ToList();
        }
        public void SortByCostDesc()
        {
            _list = _list.OrderByDescending(u => u.Cost).ToList();
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
