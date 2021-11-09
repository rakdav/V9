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
            imageMaterial.Image =Image.FromFile(material.Image);
            labelType.Text = material.MaterialTypeID;
            labelTitle.Text=material.Title;
            minCount.Text = material.MinCount.ToString();
            labelSuplier.Text = "";
            amount.Text = material.CountInStock.ToString();
        }
    }
}
