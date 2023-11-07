using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySec
{
    class Program
    {
        //组装电脑演示创建者模式
        static void Main(string[] args)
        {
            Console.WriteLine("20217124  虚拟专升本 黄英杰  建造者模式");
            Director diretor= new Director();

            Builder bulilder = new CreateBuiler();
            diretor.Construct(bulilder);
            bulilder.GetComputer().Show();

            Builder bulilder2 = new CreateBuiler2();
            diretor.Construct(bulilder2);
            bulilder2.GetComputer().Show();


            Console.ReadLine();
        }
    }
}
