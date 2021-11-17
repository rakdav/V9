using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V9.Controller;
using V9.Model;

namespace V9.View
{
    public partial class MaterialView : UserControl,IMaterialView
    {
        MaterialController _controller;
        Material material;
        public MaterialView(Material _material)
        {
            InitializeComponent();
            material = _material;
        }

        public string MaterialTypeProperties 
        {
            get { return this.labelType.Text; }
            set { this.labelType.Text = value; }
        }
        public string Title {
            get { return this.labelTitle.Text; }
            set { this.labelTitle.Text = value; }
        }
        public double MinCount {
           // get { return double.Parse(this.minCount.Text); }
            set { this.minCount.Text ="Минимальное количество:"+value.ToString(); }
        }
        public double? CountInStock
        {
          //  get { return double.Parse(this.amount.Text); }
            set { this.amount.Text = value.ToString(); }
        }
        public ICollection<Supplier> Supliers { 
            get; 
            set; 
        }

        public void Clear()
        {
            imageMaterial.Image = null;
            labelType.Text =string.Empty;
            minCount.Text = string.Empty;
            labelSuplier.Text = string.Empty;
            amount.Text = string.Empty;
        }

        public void SetController(MaterialController controller)
        {
            _controller = controller;
        }

        public void Show(Material material)
        {
            if (material.Image!=null)
            {
                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory+material.Image, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                imageMaterial.Image = img;
            }
            else
            {
                imageMaterial.Image = Properties.Resources.picture;
            }
            labelType.Text = material.MaterialTypeID;
            labelTitle.Text=material.Title;
            minCount.Text +=material.MinCount.ToString();
            string result = "";
            using (ModelDB db = new ModelDB())
            {
                List<MaterialSupplier> list = db.MaterialSupplier.Where(p=>p.MaterialID.Equals(material.Title)).ToList();
                foreach (var item in list)
                {
                    result += item.SupplierID + " ";
                }
            }
            labelSuplier.Text = result;
            amount.Text+= material.CountInStock.ToString();
            if (material.MinCount > material.CountInStock)
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f19292");
            if (material.CountInStock > 3 * material.MinCount)
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffba01");
            this.panel3.MouseClick += addActive;
            this.panel1.MouseClick += addActive;
            this.panel2.MouseClick += addActive;
            this.panel3.MouseDoubleClick += openForEdit;
            this.panel1.MouseDoubleClick += openForEdit;
            this.panel2.MouseDoubleClick += openForEdit;
        }

        private void openForEdit(object sender, MouseEventArgs e)
        {
            AddEditMaterialView addEditView = new AddEditMaterialView();
            AddEditController controller = new AddEditController(addEditView, material);
            controller.addMaterialtoView();
            if(addEditView.ShowDialog()==DialogResult.OK)
            {
                material.Title = addEditView.Title;
                material.Image = addEditView.ImagePath;
                material.Description = addEditView.Description;
                material.Cost = addEditView.Cost;
                material.CountInPack = addEditView.CountInPack;
                material.CountInStock = addEditView.CountInStock;
                material.MaterialTypeID = addEditView.MaterialTypeId;
                material.MinCount = addEditView.MinCount;
                material.Unit = addEditView.Unit;
                controller.EditMaterial(addEditView.getSuplier());
            }
        }
        private void addActive(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.DarkGreen;
            _controller.isActive = true;
            _controller.MainView.ChangeVisible();
        }

        public MaterialController getController()
        {
            return _controller;
        }
    }
}
