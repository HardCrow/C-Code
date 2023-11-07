using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huang24_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("输入x坐标:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("输入y坐标:");
                int y = int.Parse(Console.ReadLine());
                if (x > 0 && y > 0) Console.WriteLine("x={0},y={1},位于第一象限", x, y);
                else if (x < 0 && y > 0) Console.WriteLine("x={0},y={1},位于第二象限", x, y);
                else if (x < 0 && y < 0) Console.WriteLine("x={0},y={1},位于第三象限", x, y);
                else if (x > 0 && y < 0) Console.WriteLine("x={0},y={1},位于第四象限", x, y);
                else if (x == 0 && y == 0) Console.WriteLine("x={0},y={1},位于原点", x, y);
                else if (x == 0) Console.WriteLine("x={0},y={1},位于y轴", x, y);
                else if (y == 0) Console.WriteLine("x={0},y={1},位于x轴", x, y);
            }

            Console.ReadKey();
        }
    }
}
