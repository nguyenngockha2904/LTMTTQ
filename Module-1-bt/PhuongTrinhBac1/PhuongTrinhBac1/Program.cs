using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dau vao
            int a, b;
            float x;
            //nhap du lieu
            Console.Write("nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //xu ly
            if (a !=0)
            {
                x = (float)-b / a;
                Console.WriteLine("x= " + x);
            }
            else
            {
                if (b != 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");

                }
                else
                {
                    Console.WriteLine("phuong trinh co vo so nghiem");
                }
            }
            Console.ReadLine();

        }
    }
}
