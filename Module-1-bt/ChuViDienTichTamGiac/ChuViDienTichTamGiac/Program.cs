using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            //dau vao
            int a, b, c;
            int cv;
            float dt;
            float p;
            //nhap du lieu
            Console.Write("canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            //xu ly
            if (a > (b + c) || b > (a + c) || c > (b + a))
            {
                cv = a + b + c;
                p = cv / 2;
                dt = (float)Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("chu vi : {0}", cv);
                Console.WriteLine("Dien tich : "+ dt);
            }
            else
            {
                Console.WriteLine("khong phai tam giac");
            }
            Console.ReadLine();
        }
    }
}
