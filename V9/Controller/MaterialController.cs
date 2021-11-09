using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;

namespace V9.Controller
{
    public class MaterialController
    {
        IMaterialView view;
        Material material;

        public MaterialController(IMaterialView _view, Material material)
        {
            this.view =_view;
            this.material = material;
            _view.SetController(this);
        }

        public void Load()
        {
            this.view.Title = material.Title;
            this.view.Supliers = material.Supplier;
            this.view.MaterialTypeProperties = material.MaterialType;
            this.view.MinCount = material.MinCount;
            this.view.CountInStock = material.CountInStock;
        }

        private void updateUserWithViewValues(Material material)
        {
            material.Title=this.view.Title;
            material.Supplier=this.view.Supliers;
            material.MaterialType=this.view.MaterialTypeProperties;
            material.MinCount= this.view.MinCount;
            material.CountInStock= this.view.CountInStock;
        }
    }
}
