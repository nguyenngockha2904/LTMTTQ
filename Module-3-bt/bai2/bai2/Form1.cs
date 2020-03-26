using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChange(object sender, EventArgs e)
        {        
                btnArea.Enabled = true;
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtCD.Text = "";
            txtCR.Text = "";
            txtArea.Text ="";
        }
        private void btnArea_Click(object sender, EventArgs e)
        {
            double cd = Convert.ToDouble(txtCD.Text);
            double cr = Convert.ToDouble(txtCR.Text);

            txtArea.Text =(cd * cr).ToString();
        }
    }
}
