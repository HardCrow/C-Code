using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰 对象的适配器模式");
            new PowerAdapter().Reuest();
            Console.ReadLine();
        }
    }
    class ThreeHole
    {
           public virtual void Reuest()
        {
        }
    }
 /*   class a {
        public void aa()
        {
        }
    }
    class b
    {
        public override void aa()
        {
        }
    }
   */
    class TwoHole {
        public void SpcificRuest()
        {
            Console.WriteLine("使用两孔电器");
        }
    }
    class PowerAdapter :ThreeHole{
       TwoHole twoHole= new TwoHole();
        public override void Reuest()
        {
          //  base.Reuest();
            twoHole.SpcificRuest();
        }
    }


}
