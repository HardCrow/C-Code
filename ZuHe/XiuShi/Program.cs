using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiuShi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰 装饰器模式 ");
            Phone phone = new ApplePhone();
            Decorator decorator = null;
            decorator = new Sticker(phone);
            decorator.Print();
            decorator = new Accessories(phone);
            decorator.Print();

            Console.ReadLine();
        }
    }

    abstract class Phone {
        public abstract void Print();
     }
   
    class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体对象苹果手机");
        }
        
    }
    abstract class Decorator : Phone
    {
        private Phone phone;
        public Decorator(Phone phone)
        {
            this.phone = phone;
        }
        public override void Print()
        {
            phone.Print();
        }
    }
    class Sticker : Decorator {
        public Sticker(Phone phone):base (phone)
        {

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("加了贴膜功能");
        }
    }
    class Accessories : Decorator
    {
        public Accessories(Phone phone) : base(phone)
        {

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("加了挂件功能");
        }
    }


}
