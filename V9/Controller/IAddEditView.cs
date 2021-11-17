using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;

namespace V9.Controller
{
    public interface IAddEditView
    {
        void SetController(AddEditController controller);
        void addMaterial(Material material);
        string Title { get; set; }
        string MaterialTypeId { get; set; }
        double? CountInStock { get; set; }
        string Unit { get; set; }
        int CountInPack { get; set; }
        double MinCount { get; set; }
        double Cost { get; set; }
        string Description { get; set; }
        string ImagePath { get; set; }
    }
}
