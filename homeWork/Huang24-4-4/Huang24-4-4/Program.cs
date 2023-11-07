using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huang24_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("输入成绩1-100:");
                int r = int.Parse(Console.ReadLine());
                if (r >= 90)
                {
                    Console.WriteLine("成绩为优！");
                }
                else if (r >= 80)
                {
                    Console.WriteLine("成绩为良！");
                }
                else if (r >= 70)
                {
                    Console.WriteLine("成绩为中！");
                }
                else if (r >= 60)
                {
                    Console.WriteLine("成绩为及格！");
                }
                else
                {
                    Console.WriteLine("成绩为不及格！");
                }
            }
            Console.ReadKey();
        }
    }
}
