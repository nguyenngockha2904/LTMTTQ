using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //khai báo biến
        decimal tienmay = 100;
        decimal tiennguoi = 100;
        Timer timer1 = new Timer();
        private void timer1_Tick(object sender,EventArgs e)
        {
            
            decimal tienthuong;
            int so,so2,so3;
            timer1.Interval += 5;
            Random ran = new Random();
            so = ran.Next(0, 8);
            so2 = ran.Next(0, 9);
            so3 = ran.Next(0, 10);

            lblSo.Text = so.ToString();

            lblSo2.Text = so2.ToString();

            lblSo3.Text = so3.ToString();

            if (timer1.Interval > 200)
            {
                timer1.Stop();
                if (so == 7)
                {
                    tienthuong = 100 + (tienmay * 50)/100;
                    tiennguoi += tienthuong;
                    tienmay=tienmay- (tienmay * 50) / 100;
                    MessageBox.Show("Bạn được thưởng " + tienthuong + " đồng ", "lucky seven !");

                }
                if (so2 == 7)
                {
                    tienthuong = 30 + (tienmay * 50) / 100;
                    tiennguoi += tienthuong;
                    tienmay = tienmay - (tienmay * 50) / 100;
                    MessageBox.Show("Bạn được thưởng " + tienthuong + " đồng ", "lucky seven !");
                }
                if (so3 == 7)
                {
                    tienthuong = 10;
                    tiennguoi += tienthuong;
                    MessageBox.Show("Bạn được thưởng " + tienthuong + " đồng ", "lucky seven !");
                }
                txtTienMay.Text = tienmay.ToString();
                txtTienNg.Text = txtTienNg.ToString();
            }
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (tiennguoi >= 30)
            {
                timer1.Enabled = true;
                timer1.Interval = 2;
                tienmay +=30;
                tiennguoi -=30;
                txtTienMay.Text = tienmay.ToString();
                txtTienNg.Text = txtTienNg.ToString();
            }
            else
            {
                MessageBox.Show("bạn không đủ tiền để chơi tiếp");
                timer1.Enabled = false;
                btnQuaySo.Enabled = false;
            }
        }
    }
}
