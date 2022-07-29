using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace labform1
{
    public partial class Form1 : Form
    {

        public Form1(string user, string pass)//(string user)
        {

            InitializeComponent();
            lbl_logname.Text = user;

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
            /*   string message = " ";
               foreach(var item in checkedListBox1.CheckedItems)
               {
                   message+=item.ToString();   
               }
               MessageBox.Show(message);
               if (radioButton1.Checked)
               {
                   MessageBox.Show("simple");
               }
               if (radioButton2.Checked)
               {
                   MessageBox.Show("variable");
               }
              */
            Boolean isVal = true;
            Regex re = new Regex(@"^[0-9]{5}$");
            if (!re.IsMatch(txt_inventorynumber.Text))
            {

                errorProvider1.SetError(txt_inventorynumber, "invalid inventory number!");
                isVal = false;

            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {

                int.Parse(txt_number.Text);
                errorProvider3.Clear();

            }
            catch (Exception)
            {

                errorProvider3.SetError(txt_number, "invalid number!");
                isVal = false;
            }
            if (string.IsNullOrEmpty(txt_objectname.Text))
            {
                errorProvider2.SetError(txt_objectname, "invalid object name!");
                isVal = false;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (isVal)
            {

                item items = new item();
                items.Number = int.Parse(txt_number.Text);
                items.Date = txt_date.Text;
                items.Inventorynum = int.Parse(txt_inventorynumber.Text);
                items.Objectname = txt_objectname.Text;
                items.Count = int.Parse(txt_count.Text);
                items.Price = double.Parse(txt_price.Text);
                items.isAvailable = chkbox_isavail.Checked;
                items.isSimple = radioBtn_Simple.Checked;
                items.isVariable = radioBtn_variable.Checked;
                string message = "";
                /*  foreach(var item in checkedListBox1.CheckedItems)
                  {
                      items.isExtReg = checkedListBox1.CheckedItems.Contains(item);
                  }*/
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    message += item.ToString() + '\n';
                }
                MessageBox.Show(message);

                items.Save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = item.getAll();

            }
            ;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_objectname_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
