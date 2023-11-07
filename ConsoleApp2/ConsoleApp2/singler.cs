using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Singler
    {
        private Singler()
        {
            Console.WriteLine("test1 构造器初始化的");

        }
        private static Singler singler ;
        public static Singler GetSingler()
        {
            if (singler == null) 
                singler = new Singler();
                return singler; 
        }
        public void Show()
        {
            Console.WriteLine("test1  方法调用的");      }
    }
}
