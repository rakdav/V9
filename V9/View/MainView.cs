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
        public MainView()
        {
            InitializeComponent();
        }

        public void AddMatirial(Material material)
        {
            MaterialView materialView = new MaterialView();
            materialView.Show(material);
            this.flowLayoutPanel1.Controls.Add(materialView);
        }

        public void Clear()
        {
            this.flowLayoutPanel1.Controls.Clear();
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
            linkLabel.LinkClicked += this.addFiveMaterial;
            this.flowLayoutPanel2.Controls.Add(linkLabel);
        }
        private void addFiveMaterial(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int n = int.Parse((sender as LinkLabel).Text);
            controller.LoadView(n);
        }
        public void RemoveMaterial(Material material)
        {
            throw new NotImplementedException();
        }

        public void SetController(MainController _controller)
        {
            controller = _controller;
        }

        public void UpdateWithChangedMatirial(Material material)
        {
            throw new NotImplementedException();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

    }
}
