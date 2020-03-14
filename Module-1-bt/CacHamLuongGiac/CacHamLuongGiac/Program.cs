using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacHamLuongGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            //dau vao
            int x;
            float a;
            //nhap du lieu
            Console.Write("Nhap vao 1 goc :");
            x = Convert.ToInt32(Console.ReadLine());
            //xu ly
            a = (float) (x * Math.PI) / 180;
            //dau ra
            Console.WriteLine("Sin({0}) = {1}",x,Math.Sin(a));
            Console.WriteLine("Cos({0}) = {1}", x, Math.Cos(a));
            Console.WriteLine("Tan<" + x + "> =" + Math.Tan(a));
            Console.WriteLine("Sin<" + x + "> =" + 1/(Math.Tan(a)));
            Console.ReadLine();
        }
    }
}
