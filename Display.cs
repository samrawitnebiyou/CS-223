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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            item.getAll();
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = item.getAll();

        }

        private void Display_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }
    }
}

















