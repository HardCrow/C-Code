using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctPerject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("虚拟现实专升本的复杂工厂20217124 黄英杰");
            Creator  tomatos=   new Tomatos();
            Creator potatos = new Potatoes();
            Creator xilan = new Xis();
            tomatos.CreatFood().Print();
            potatos.CreatFood().Print();
            xilan.CreatFood().Print();
            Console.ReadLine();
        }
    }
    abstract class Food
    {
        abstract public void Print();
    }
    class Tomato : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份炒的西红柿");
        }
    }
    class Potato : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份煮的土豆");
        }
    }
    class Xi : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份系的西兰花");
        }
    }

    abstract class Creator {
        public abstract Food CreatFood();
    }
    class Tomatos : Creator
    {
        public override Food CreatFood()
        {
            return new Tomato();
        }
      
    }
    class Potatoes : Creator
    {
        public override Food CreatFood()
        {
            return new Potato();
        }

    }
    class Xis : Creator
    {
        public override Food CreatFood()
        {
            return new Xi();
        }

    }

}