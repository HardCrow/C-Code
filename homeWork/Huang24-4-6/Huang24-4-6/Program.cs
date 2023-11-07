using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huang24_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int y;
                Console.WriteLine("输入x值:");
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                    y = 1;
                else if (x == 0)
                    y = 0;
                else
                    y = -1;
                Console.WriteLine("输出y的值为：" + y);
            }
            Console.ReadKey();
        }
    }
}
