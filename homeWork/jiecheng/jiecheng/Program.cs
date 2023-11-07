using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiecheng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要求阶层的数：");
            int a = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("你输入的数字为{0}，{1}的阶层为：{2}", a, a, sum);
            Console.ReadLine(); 
        }
    }
}
