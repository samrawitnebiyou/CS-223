using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labform1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_stusearch_Click(object sender, EventArgs e)
        {
            var product = item.findone(txt_stuname.Text);
            if (product == null)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                textBox1.Text = Convert.ToString(product.Number);
                textBox2.Text = Convert.ToString(product.Inventorynum);
                textBox3.Text = product.Objectname;
                textBox4.Text = Convert.ToString(product.Price);
                textBox5.Text = Convert.ToString(product.Count);
                textBox6.Text= Convert.ToString(product.Date);
                textBox7.Text= Convert.ToString(product.isExtension);
                textBox8.Text= Convert.ToString(product.isRegular);
                textBox9.Text= Convert.ToString(product.isVariable);
                textBox10.Text = Convert.ToString(product.isSimple);
                textBox11.Text= Convert.ToString(product.isAvailable);
            }
        }

        private void txt_stuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


