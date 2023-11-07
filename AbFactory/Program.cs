using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰  抽象工厂");
            AbsFactory nanchang=new NanChangFactory();
            nanchang.CreatDuckNeck().Print();
            nanchang.CreatDuckReck().Print();
            AbsFactory shanghai = new ShangHaiFactory();
            shanghai.CreatDuckReck().Print();
            shanghai.CreatDuckNeck().Print();
            Console.ReadLine();
        }

    }
    abstract class AbsFactory
    {
        abstract public DuckNeck CreatDuckNeck();
        abstract public DuckRack CreatDuckReck();

    }

    abstract class DuckNeck
    {
        public abstract void Print();
    }
    class NanChangDuckNeck : DuckNeck
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭脖");
        }

    }
    class ShangHaiDuckNeck : DuckNeck
    {
        public override void Print()
        {
            Console.WriteLine("上海的鸭脖 ");
        }
    }

    abstract class DuckRack
    {
        public abstract void Print();
    }
    class NanChangDuckRack : DuckRack
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭架");
        }
    }
    class ShangHaiDuckRack : DuckRack
    {
        public override void Print()
        {
            Console.WriteLine("上海的鸭架");
        }

    }

    class NanChangFactory : AbsFactory
    {
        public override DuckNeck CreatDuckNeck()
        {
             return new NanChangDuckNeck();
        }

        public override DuckRack CreatDuckReck()
        {
            return new NanChangDuckRack();
        }
    }
    class ShangHaiFactory : AbsFactory
    {
        public override DuckNeck CreatDuckNeck()
        {
            return new ShangHaiDuckNeck();
        }

        public override DuckRack CreatDuckReck()
        {
            return new ShangHaiDuckRack();
        }
    }
}
