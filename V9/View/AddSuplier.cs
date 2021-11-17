using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V9.Model;

namespace V9.View
{
    public partial class AddSuplier : Form
    {
        IList<string> mas;
        public AddSuplier()
        {
            InitializeComponent();
            mas = new List<string>();
            using (ModelDB db=new ModelDB())
            {
                List<Supplier> list = db.Supplier.ToList();
                foreach (Supplier item in list)
                {
                    comboBox1.Items.Add(item.Title);
                    mas.Add(item.Title);
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                string[] UpdatedComboBoxItems = mas.Where(x => x.Contains(comboBox1.Text)).OrderBy(x => x.IndexOf(comboBox1.Text)).ToArray();

                //Removes every element from the combobox control. Combobox.Items.Clear causes the cursor position to reset.
                foreach (string Element in mas)
                    comboBox1.Items.Remove(Element);

                //Re-adds all the element in order.
                comboBox1.Items.AddRange(UpdatedComboBoxItems);

        }
    }
}
