using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MyfistApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
        
            KhachHang kh = new KhachHang();
            kh.MaKH = "123345345";
            Console.WriteLine(" MaKH : " + kh.MaKH);
            
            
            Console.ReadLine();
        }
    }
}
