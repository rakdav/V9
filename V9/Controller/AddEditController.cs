using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V9.Model;

namespace V9.Controller
{
    public class AddEditController
    {
        IAddEditView _view;
        Material material;

        public AddEditController(IAddEditView view, Material material)
        {
            _view = view;
            this.material = material;
            _view.SetController(this);
        }

       
   
    public void addMaterialtoView()
        {
            _view.Title = material.Title;
            _view.CountInStock = material.CountInStock;
            _view.CountInPack = material.CountInPack;
            _view.Cost = material.Cost;
            _view.Description = material.Description;
            _view.MinCount = material.MinCount;
            _view.Unit = material.Unit;
            _view.ImagePath = material.Image;
            _view.MaterialTypeId = material.MaterialTypeID;
        }

        public void LoadView()
        {
            _view.addMaterial(material);
        }

        public void AddMaterial(List<string> sup)
        {
            using (ModelDB db=new ModelDB())
            {
                db.Material.Add(material);
                foreach(string i in sup)
                {
                    MaterialSupplier materialSupplier = new MaterialSupplier();
                    materialSupplier.MaterialID = material.Title;
                    materialSupplier.SupplierID = i;
                    db.MaterialSupplier.Add(materialSupplier);
                    db.SaveChanges();
                }
            }
        }
        public void EditMaterial(List<string> sup)
        {
            using (ModelDB db = new ModelDB())
            {
                Material forChange = db.Material.Where(p=>p.Title.Equals(material.Title)).FirstOrDefault();
                foreach (string i in sup)
                {
                    MaterialSupplier materialSupplier = new MaterialSupplier();
                    materialSupplier.MaterialID = material.Title;
                    materialSupplier.SupplierID = i;
                    db.MaterialSupplier.Add(materialSupplier);
                }
                if (forChange != null)
                {
                    forChange=material;
                    db.SaveChanges();
                }
                db.SaveChanges();
            }
        }
        public void DeleteMaterial(string title)
        {
            using (ModelDB db=new ModelDB())
            {
                Material m = db.Material.Where(p=>p.Title.Equals(title)).FirstOrDefault();
                if (m != null)
                {
                    db.Entry(m).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }
    }
}
