using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("虚拟现实专升本的简单工厂20217124 黄英杰");
            FoodFactory.creatFood("西红柿").Print();
            FoodFactory.creatFood("土豆").Print();
            FoodFactory.creatFood("西兰花").Print();
            Console.ReadLine();
        }
    }
    abstract class Food{
        abstract public void Print();
        }
    class Tomato :Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿");
        }
    }
    class Potato : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆");
        }
    }
    class Xi : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西兰花");
        }
    }
    class FoodFactory
    {
        public static Food creatFood(string name)
        {
            Food food = null;
           if (name.Equals("西红柿"))
            {
               food = new Tomato();
            }
           else if (name.Equals("土豆"))
            {
                food = new Potato();
            }
            else if (name.Equals("西兰花"))
            {
                food = new Xi();
            }
            else
            
                Console.WriteLine("代码或者输入错误");
            
            return food;

        }

    }
}
