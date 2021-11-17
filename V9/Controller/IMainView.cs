using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;
using V9.View;

namespace V9.Controller
{
    public interface IMainView
    {
        void SetController(MainController controller);
        void Clear();
        void AddMatirial(Material material);
        void AddPage(int n);
        void AddLeftRight(string text);
        void UpdateWithChangedMatirial(Material material);
        void RemoveMaterial(MaterialView material);
        void addTypeMaterial(string[] material);
        void setTitle(int all, int otbor);
        void ChangeVisible();
    }
}
