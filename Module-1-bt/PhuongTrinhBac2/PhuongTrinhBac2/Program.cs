using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dau vao
            float a, b, c;
            float denta;
            //nhap du lieu 
            Console.WriteLine("ax2+bx+c=0");
            Console.Write("a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c : ");
            c = Convert.ToInt32(Console.ReadLine());
            //xu ly
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("phuong trinh co vo so nghiem");

                    }else
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("phuong trinh co 1 nghiem x=" +((float)- c / b));
                }
            }
            else
            {
                denta = b * b - 4 * a * c;
                if (denta > 0)
                {
                    Console.WriteLine("phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = " + (float)(-b - Math.Sqrt(denta)) / (2 * a));
                    Console.WriteLine("x2 = " + (float)(-b + Math.Sqrt(denta)) / (2 * a));
                }else if(denta == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("x1 = x2 = "+(float)(-b)/(2*a));

                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem ");
                }
            }
            Console.ReadLine();
        }

    }
}
