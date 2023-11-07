using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chengfa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九乘法表");
            string s;
            for (int i = 1; i <= 9; i++)
            {
                s = "";
                for (int j = 1; j <= 9; j++)
                {
                    s += (string.Format("{0}*{1}={2}", i, j, i * j)).PadRight(8);
                }
                Console.WriteLine(s);
            }

            Console.WriteLine("九九乘法表下三角");
            string d;
            for (int i = 1; i <= 9; i++)
            {
                d = "";
                for (int j = 1; j <= i; j++)
                {
                    d += (string.Format("{0}*{1}={2}", i, j, i * j)).PadRight(8);
                }
                Console.WriteLine(d);
            }

            Console.WriteLine("九九乘法表上三角");
            string u;
            for (int i = 1; i <= 9; i++)
            {
                u = "";
                for (int j = i; j <= 9; j++)
                {
                    u += (string.Format("{0}*{1}={2}", i, j, i * j)).PadRight(8);
                }
                Console.WriteLine(u);
            }
            Console.ReadLine();
        }
    }
}
