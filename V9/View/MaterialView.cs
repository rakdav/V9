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
        public MaterialView()
        {
            InitializeComponent();
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
            get { return double.Parse(this.minCount.Text); }
            set { this.labelType.Text = value.ToString(); }
        }
        public double? CountInStock
        {
            get { return double.Parse(this.amount.Text); }
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
        }
    }
}
