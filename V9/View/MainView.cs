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
using V9.View;

namespace V9
{
    public partial class MainView : Form,IMainView
    {
        MainController controller;
        private int n;
        List<MaterialView> mviews;
        public MainView()
        {
            InitializeComponent();
            n = 1;
            sortBy.SelectedIndex = 0;
            mviews = new List<MaterialView>();
        }

        public void AddMatirial(Material material)
        {
            MaterialView materialView = new MaterialView(material);
            MaterialController materialController = new MaterialController(materialView,this, material);
            materialView.Show(material);
            this.flowLayoutPanel1.Controls.Add(materialView);
            mviews.Add(materialView);
        }

        public void Clear()
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel2.Controls.Clear();
        }

        public void AddPage(int n)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = n.ToString();
            linkLabel.Size = new Size(20,50);
            linkLabel.LinkClicked+= this.addFiveMaterial;
            this.flowLayoutPanel2.Controls.Add(linkLabel);
        }
        public void AddLeftRight(string text)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = text;
            linkLabel.Size = new Size(10, 50);
            if(text.Equals("<"))
                linkLabel.LinkClicked += this.addLeftMaterial;
            else
                linkLabel.LinkClicked += this.addRightMaterial;
            this.flowLayoutPanel2.Controls.Add(linkLabel);
        }
        private void addFiveMaterial(object sender, LinkLabelLinkClickedEventArgs e)
        {
            n = int.Parse((sender as LinkLabel).Text);
            controller.LoadView(n);
        }

        private void addLeftMaterial(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (n > 1)
            {
                n--;
                controller.LoadView(n);
            }
        }
        private void addRightMaterial(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (n < controller.getCount())
            {
                n++;
                controller.LoadView(n);
            }
        }
        public void ChangeVisible()
        {
            this.btChangeMinCount.Visible = true;
        }
        public void RemoveMaterial(MaterialView material)
        {
            this.flowLayoutPanel1.Controls.Remove(material);
        }

        public void SetController(MainController _controller)
        {
            controller = _controller;
        }

        public void UpdateWithChangedMatirial(Material material)
        {
            throw new NotImplementedException();
        }

        private void SortMethod()
        {
            if (sortBy.SelectedIndex == 1)
            {
                if (sortByDesc.Checked)
                    controller.SortByNameDesc();
                else
                    controller.SortByName();
            }
            else if (sortBy.SelectedIndex == 2)
            {
                if (sortByDesc.Checked)
                    controller.SortByAmountDesc();
                else
                    controller.SortByAmount();
            }
            else if (sortBy.SelectedIndex == 3)
            {
                if (sortByDesc.Checked)
                    controller.SortByCostDesc();
                else
                    controller.SortByCost();
            }
            if (sortBy.SelectedIndex != 0)
                controller.LoadView(n);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortMethod();
        }

        private void sortByDesc_CheckedChanged(object sender, EventArgs e)
        {
            SortMethod();
        }

        private void radioSortAsc_CheckedChanged(object sender, EventArgs e)
        {
            SortMethod();
        }

        public void addTypeMaterial(string[] material)
        {
            foreach (string item in material)
            {
                materialFilter.Items.Add(item);
            }          
        }

        private void materialFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialFilter.SelectedIndex != 0)
                controller.filterBy(materialFilter.SelectedItem.ToString());
            else controller.nofilter();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                controller.nofilter();
            else controller.filterByName(textBox1.Text);
        }
        public void setTitle(int all,int otbor)
        {
           this.toolStripStatusLabel1.Text =otbor + " из " + all;
        }

        private void btChangeMinCount_Click(object sender, EventArgs e)
        {
            ChangeMinCount change = new ChangeMinCount();
            if (change.ShowDialog() == DialogResult.OK)
            {
                foreach (MaterialView mv in mviews)
                {
                    MaterialController controller = mv.getController();
                    if (controller.isActive)
                    {
                        mv.MinCount = int.Parse(change.MinCount.Text);
                        Material material = controller.GetMaterial();
                        material.MinCount = int.Parse(change.MinCount.Text);
                        controller.updateUserWithViewValues(material);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditMaterialView view = new AddEditMaterialView();
            view.Visible = false;
            Material material = new Material();
            AddEditController controller = new AddEditController(view,material);
            if(view.ShowDialog()==DialogResult.OK)
            {
                material.Title = view.Title;
                material.MinCount = view.MinCount;
                material.MaterialTypeID = view.MaterialTypeId;
                material.Image = view.ImagePath;
                material.Unit = view.Unit;
                material.Cost = view.Cost;
                material.CountInPack = view.CountInPack;
                material.CountInStock = view.CountInStock;
                material.Description = view.Description;          
                controller.AddMaterial(view.getSuplier());
                AddMatirial(material);
            } 
            else if(view.ShowDialog()==DialogResult.Yes)
            {
                MaterialView materialView = new MaterialView(material);
                MaterialController materialController = new MaterialController(materialView, this, material);
                RemoveMaterial(materialView);
            }
        }
    }
}
