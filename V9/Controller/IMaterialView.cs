using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;

namespace V9.Controller
{
    public interface IMaterialView
    {
        void SetController(MaterialController controller);
        void Clear();
        void Show(Material material);
        void UpdateView(Material material);
        string MaterialType { get; set; }
        string Title { get; set; }
        double MinCount { get; set; }
        double CountInStock { get; set; }
        List<string> Supliers { get; set; }
    }
}
