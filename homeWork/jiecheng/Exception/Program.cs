using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("请输入被除数：");
            try
            {
                String s = Console.ReadLine();
                i = int.Parse(s);
                Console.WriteLine("请输入除数：");
                s = Console.ReadLine();
                j = int.Parse(s);
                k = i / j;
                Console.WriteLine("被除数/除数 = {0}", k);
            }
            catch (FormatException e1)
            {
                Console.WriteLine("输入格式不正确！");
            }
            catch (DivideByZeroException e2)
            {
                Console.WriteLine("除数不能为0！");

            }
            Console.ReadKey();
        }
    }
}
 
