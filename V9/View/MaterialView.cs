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

        public MaterialType MaterialTypeProperties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MinCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double? CountInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<Supplier> Supliers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Clear()
        {
            imageMaterial.Image = null;
            labelTypeAndName.Text =string.Empty;
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
            labelTypeAndName.Text = material.Title;
            minCount.Text = material.MinCount.ToString();
            labelSuplier.Text = "";
            amount.Text = material.CountInStock.ToString();
        }
    }
}
