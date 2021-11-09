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

namespace V9
{
    public partial class Form1 : Form,IMainView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddMatirial(Material material)
        {
            IMaterialView materialView=new IMaterialView
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void RemoveMaterial(Material material)
        {
            throw new NotImplementedException();
        }

        public void SetController(MainController controller)
        {
            throw new NotImplementedException();
        }

        public void UpdateWithChangedMatirial(Material material)
        {
            throw new NotImplementedException();
        }
    }
}
