using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V9.Controller;
using V9.Model;

namespace V9.View
{
    public partial class AddEditMaterialView : Form,IAddEditView
    {
        AddEditController _controller;
        private string pathToImage;
        public AddEditMaterialView()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string MaterialTypeId 
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value.ToString(); }
        }
        public double? CountInStock 
        {
            get { return double.Parse(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public string Unit {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int CountInPack
        {
            get { return int.Parse(textBox4.Text); }
            set { textBox4.Text = value.ToString(); }
        }
        public double MinCount 
        {
            get { return double.Parse(textBox5.Text); }
            set { textBox5.Text = value.ToString(); }
        }
        public double Cost 
        {
            get { return double.Parse(textBox6.Text); }
            set { textBox6.Text = value.ToString(); }
        }
        
        public string Description {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        public string ImagePath
        {
            get { return pathToImage; }
            set {
                if (value != null)
                    pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory+value.ToString());
                else
                    pictureBox1.Image = Properties.Resources.picture;
            }
        }

        public void addMaterial(Material material)
        {
            throw new NotImplementedException();
        }

        public List<string> getSuplier()
        {
            List<string> list = new List<string>();
            foreach(string i in listBox1.Items)
            {
                list.Add(i);
            }
            return list;
        }
        public void SetController(AddEditController controller)
        {
            _controller = controller;
        }

        private void AddEditMaterialView_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            using (ModelDB db=new ModelDB())
            {
                List<MaterialType> list = db.MaterialType.ToList();
                foreach (MaterialType item in list)
                {
                    comboBox1.Items.Add(item.Title);
                }
                List<MaterialSupplier> msList = db.MaterialSupplier.Where(p=>p.MaterialID.Equals(textBox1.Text)).ToList();
                foreach (MaterialSupplier item in msList)
                {
                    listBox1.Items.Add(item.SupplierID);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);  
            pathToImage= @"\materials\" + openFileDialog1.SafeFileName;

            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
            if(fileInfo.Exists)
            {
                fileInfo.CopyTo(Environment.CurrentDirectory+pathToImage,true);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSuplier add = new AddSuplier();
            if(add.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Add(add.comboBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _controller.DeleteMaterial(textBox1.Text);
            button6.DialogResult = DialogResult.Yes;
        }
    }
}
