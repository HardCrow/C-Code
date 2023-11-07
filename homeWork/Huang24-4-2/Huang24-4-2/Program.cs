using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huang24_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, t;
            Random rNum = new Random();
            a = rNum.Next(101);
            b = rNum.Next(101);
            Console.WriteLine("初始值，a={0},b={1}", a, b);
            if (a < b)
            {
                t = a; a = b; b = t;
            }
            Console.WriteLine("降序值:a={0},b={1}", a, b);
            Console.ReadKey();
        }
    }
}
