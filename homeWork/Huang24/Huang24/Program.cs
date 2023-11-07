using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huang24
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("输入一个字符:");
                char ch = char.Parse(Console.ReadLine());
                if (Char.ToUpper(ch) >= 'A' && Char.ToUpper(ch) <= 'Z')
                {
                    if (ch >= 'A' && ch <= 'Z')
                        Console.WriteLine("该字母是大写字母！");
                    else

                        Console.WriteLine("该字母是小写字母！");
                }
                else if (ch >= '0' && ch <= '9')
                {
                    Console.WriteLine("该字母是数字符！");
                }
                else
                { Console.WriteLine("该字母是其他符！"); }
            }
            Console.ReadKey();
        }
    }
}
