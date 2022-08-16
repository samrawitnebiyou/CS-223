using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labform2
{
    public partial class Form2 :Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
                "item 1","item 2","21.3"
            };
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in list)
            {
                UserControl1 card = new UserControl1();
                card.TITLE = item;
                //card.PRICE = item;
                flowLayoutPanel1.Controls.Add(card);

            }

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }
    }
}

        

     

