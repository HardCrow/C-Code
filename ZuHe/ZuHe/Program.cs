using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuHe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰 组合模式 ");
            Grapgics grapgics = new CompleGrapgics("一个复合图形加两个线段组成");
            grapgics.Add(new Line("线段a"));
            Grapgics b = new Line("线段b");
            grapgics.Add(b);
            CompleGrapgics compleGrapgics = new CompleGrapgics("一个圆加两个线段");
            compleGrapgics.Add(new Cirle("圆c"));
            compleGrapgics.Add(new Line("线段d"));
            compleGrapgics.Add(new Line("线段e"));
            grapgics.Add(compleGrapgics);
            Console.WriteLine("复合图形");
            grapgics.Draw();
            Console.WriteLine("绘制完成");
            Console.WriteLine("移除b");
            grapgics.Remove(b);
            grapgics.Draw();
            Console.ReadLine();
        }
        abstract class Grapgics
        {
            private string name;

            public string Name { get => name; set => name = value; }
            public Grapgics(string name)
            {
                this.name = name;
            }
            public abstract void Draw();
            public abstract void Add(Grapgics g);
            public abstract void Remove(Grapgics g);

        }
        class Line : Grapgics
        {
            public Line(string name) : base(name)
            {

            }

            public override void Add(Grapgics g)
            {
                throw new NotImplementedException();
            }

            public override void Draw()
            {
                Console.WriteLine("绘制图形 line" + Name);
            }

            public override void Remove(Grapgics g)
            {
                throw new NotImplementedException();
            }
        }
        class Cirle : Grapgics
        {
            public Cirle(string name) : base(name)
            {

            }

            public override void Add(Grapgics g)
            {
                throw new NotImplementedException();
            }

            public override void Draw()
            {
                Console.WriteLine("绘制图形 line" + Name);
            }

            public override void Remove(Grapgics g)
            {
                throw new NotImplementedException();
            }
        }
        class CompleGrapgics : Grapgics
        {
            public CompleGrapgics(string name) : base(name)
            {

            }
            List<Grapgics> grapgicsList = new List<Grapgics>();

            public override void Add(Grapgics g)
            {
                grapgicsList.Add(g);
            }

            public override void Draw()
            {
              
                foreach (var item in grapgicsList)
                {
                    item.Draw();
                }
            }

            public override void Remove(Grapgics g)
            {
                grapgicsList.Remove(g);
                Console.WriteLine("删除图形 " + Name);
            }
        }
    }
}
