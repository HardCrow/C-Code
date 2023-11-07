using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class singlerTwo
    {
        private singlerTwo()
        {
            Console.WriteLine("test2 构造器初始化的");
        }
        private static singlerTwo singlertwo = new singlerTwo();
        public static singlerTwo GetSinglerTwo()
        {
            return singlertwo;
        }
        public void Show()
        {
            Console.WriteLine("test2  方法调用的");
        }
    }
}
