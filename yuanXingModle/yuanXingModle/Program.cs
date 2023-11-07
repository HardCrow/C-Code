using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuanXingModle
{
    class Program
    {
        //区别深拷贝和浅拷贝
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰");
            MonkeyKingProperty p1 = new MonkeyKingProperty();
            p1.age = 18;
            p1.IdInfo = new IdInfo(25);

            //浅
            MonkeyKingProperty p2 = p1.ShallowCopy();
            //深
            MonkeyKingProperty p3 = p1.DeepCopy();
            Console.WriteLine("原来的值");
            Display(p1);
            Display(p2);
            Display(p3);
            Console.WriteLine();
            p1.age = 28;
            p1.IdInfo.Id = 35;
            Console.WriteLine("修改的值");
            Display(p1);
            Display(p2);
            Display(p3);
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Display(MonkeyKingProperty p)
        {
            Console.WriteLine("age:{0},id:{1}", p.age, p.IdInfo.Id);
        }
    }
    class MonkeyKingProperty
    {
        public int age;
        public IdInfo IdInfo;
        public MonkeyKingProperty ShallowCopy() {
           
            return (MonkeyKingProperty)this.MemberwiseClone() ;   //浅拷贝
        }
        public MonkeyKingProperty DeepCopy()
        {
            MonkeyKingProperty clone = this.MemberwiseClone() as MonkeyKingProperty;
            clone.IdInfo = new IdInfo(IdInfo.Id);    //深
            return clone;
        }
    }
    class IdInfo {
        public int Id;
        public IdInfo(int Id)
        {
            this.Id=Id;

        }
    }

}
