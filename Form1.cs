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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            item stud = new item();
            stud.Number = int.Parse(txt_number.Text);
            stud.Date = txt_date.Text;
            stud.Inventorynum = int.Parse(txt_inventorynumber.Text);
            stud.Objectname = txt_objectname.Text;
            stud.Count = int.Parse(txt_count.Text);
            stud.Price = int.Parse(txt_price.Text);
            stud.Save();
            MessageBox.Show("SAVED");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
