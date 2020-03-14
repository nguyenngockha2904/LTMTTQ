using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            //dau vao
            int cd,cr;
            int dientich, chuvi;
            //nhap du lieu
            Console.Write("nhap vao chieu dai :");
            cd = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap vao chieu rong :");
            cr = Convert.ToInt32(Console.ReadLine());
            //xu ly
            dientich = cd * cr;
            chuvi = cd * 2 + cr * 2;
            //dau ra
            Console.WriteLine("Chu vi : " + chuvi);
            Console.WriteLine("Dien Tich : " + dientich);
            Console.ReadLine();
        }
    }
}
