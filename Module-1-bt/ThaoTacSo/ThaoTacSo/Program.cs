using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            //đầu vào 
            int nSo1, nSo2, nTong = 0;
            Console.Clear();
            //nhâp dữ liệu
            Console.Write("{0}", "nhap so thu nhat :");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so thu hai :");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            //xu ly
            nTong = nSo1 + nSo2;
            //dau ra
            Console.WriteLine("tong : " + nSo1 + "+" + nSo2 + "= " + nTong);
            Console.ReadLine();

        }
    }
}
