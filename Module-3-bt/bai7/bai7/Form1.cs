using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChance_Click(object sender, EventArgs e)
        {
            int namDuong = Convert.ToInt32(txtNamDuong.Text);
            int can = namDuong % 10;
            int chi= namDuong % 12;
            String amlich="";
            switch (can)
            {
                case 0:
                    {
                        amlich += "Canh ";
                        break;
                    }
                case 1:
                    {
                        amlich += "Tân ";
                        break;
                    }
                case 2:
                    {
                        amlich += "Nhâm ";
                        break;
                    }
                case 3:
                    {
                        amlich += "Quý ";
                        break;
                    }
                case 4:
                    {
                        amlich += "Giáp ";
                        break;
                    }
                case 5:
                    {
                        amlich += "Ất ";
                        break;
                    }
                case 6:
                    {
                        amlich += "Bính ";
                        break;
                    }
                case 7:
                    {
                        amlich += "Đinh ";
                        break;
                    }
                case 8:
                    {
                        amlich += "Mậu ";
                        break;
                    }
                case 9:
                    {
                        amlich += "Kỷ ";
                        break;
                    }

            }
            switch (chi)
            {
                case 0:
                    {
                        amlich += "Thân";
                        break;
                    }
                case 1:
                    {
                        amlich += "Dậu";
                        break;
                    }
                case 2:
                    {
                        amlich += "Tuất";
                        break;
                    }
                case 3:
                    {
                        amlich += "Hợi";
                        break;
                    }
                case 4:
                    {
                        amlich += "Tý";
                        break;
                    }
                case 5:
                    {
                        amlich += "Sửu";
                        break;
                    }
                case 6:
                    {
                        amlich += "Dần";
                        break;
                    }
                case 7:
                    {
                        amlich += "Mẹo";
                        break;
                    }
                case 8:
                    {
                        amlich += "Thìn";
                        break;
                    }
                case 9:
                    {
                        amlich += "Tỵ";
                        break;
                    }
                case 10:
                    {
                        amlich += "Ngọ";
                        break;
                    }
                case 11:
                    {
                        amlich += "Mùi";
                        break;
                    }
            }
            txtNamAmLich.Text = amlich;
        }
    }
}
