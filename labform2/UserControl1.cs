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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private string _title;
        private string _description;
        private double _price;
        public string TITLE
        {
            get { return _title; }
            set { _title = value; label1.Text = value; label2.Text = value; label3.Text = value; }
        }
      
        public string DESCRIPTION
        {
            get { return _description; }
            set { _description = value; label2.Text = value; }
        }
    
        public double PRICE
        {
            get { return _price; }
            set { _price = value; label3.Text = Convert.ToString(value); }

           }
        

    }











        }
   
