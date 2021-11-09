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
            this.Controls.Clear();
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
