using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰类的适配器模式");
              //
            new PowerAdapter().SpecificRequest();
            Console.ReadLine();
        }
    }
    //适配器
    class PowerAdapter : TwoHole, ThreeHole
    {

        public void Request()
        {
            SpecificRequest();
        }
    }
    //双
    abstract class TwoHole
    {
        public  void SpecificRequest()
        {
            Console.WriteLine("使用两孔电器");
        }
    }
    //三
    interface ThreeHole {
        void Request();

    }
}
