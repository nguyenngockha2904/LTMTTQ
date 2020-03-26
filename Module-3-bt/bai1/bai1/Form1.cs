using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenMH.Focus();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            int sl =Convert.ToInt32(txtSL.Text);
            int dg = Convert.ToInt32(txtDG.Text);
            if (sl > 0 && dg > 0)
            {
                txtTT.Text = (sl * dg).ToString();
            }
            else
            {
                MessageBox.Show("số lượng và đơn giá phải >0");

            }
        }
    }
}
