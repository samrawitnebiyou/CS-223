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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

      
        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Form2 screen=new Form2();
            screen.MdiParent=this;
            screen.Show();
        }

        private void newStudentToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {

        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen!=null)
            {
                activescreen.Close();
            }
            Display screen =new Display();
            screen.MdiParent=this;
            screen.Show();
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Form4 screen = new Form4();
            screen.MdiParent = this;
            screen.Show();

        }
    }
}
