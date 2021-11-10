using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;

namespace V9.Controller
{
    public interface IMainView
    {
        void SetController(MainController controller);
        void Clear();
        void AddMatirial(Material material);
        void AddPage(int n);
        void UpdateWithChangedMatirial(Material material);
        void RemoveMaterial(Material material);
    }
}
