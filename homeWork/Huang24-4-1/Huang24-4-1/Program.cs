using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huang24_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, s;
            Console.WriteLine("输入三角形的边A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("输入三角形的边B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("输入三角形的边C:");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("三角形的三边为" + a + b + c);
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("三角形的面积为" + s);
            Console.ReadKey();

        }
    }
}
