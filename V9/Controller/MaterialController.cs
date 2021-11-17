using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;

namespace V9.Controller
{
    public class MaterialController
    {
        IMaterialView view;
        IMainView mainView;
        Material material;
        public bool isActive { get; set; }
        public MaterialController(IMaterialView _view,IMainView m, Material material)
        {
            this.view =_view;
            this.mainView = m;
            this.material = material;
            _view.SetController(this);
        }

        public void Load()
        {
            this.view.Title = material.Title;
            this.view.MaterialTypeProperties = material.MaterialTypeID;
            this.view.MinCount = material.MinCount;
            this.view.CountInStock = material.CountInStock;
        }

        public void updateUserWithViewValues(Material material)
        {
            material.Title=this.view.Title;
            material.MaterialTypeID=this.view.MaterialTypeProperties;
          //  material.MinCount= this.view.MinCount;
           // material.CountInStock= this.view.CountInStock;
            using(ModelDB db=new ModelDB())
            {
                Material m = db.Material.Where(p => p.Title.Equals(material.Title)).FirstOrDefault();
                m.MinCount = material.MinCount;
                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Material GetMaterial()
        {
            return material;
        }
        public IMainView MainView
        {
            get { return mainView; }
        }

    }
}
