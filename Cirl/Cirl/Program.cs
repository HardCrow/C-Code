using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("半径为");
            double r = double.Parse(Console.ReadLine());
            Test test = new Test();
            double p = test.Perimeter(r);
            Console.WriteLine("周长为" + p);
            double s = test.S(r);
            Console.WriteLine("面积为" + s);
            double v = test.V(r);
            Console.WriteLine("体积为" + v);
            Console.ReadLine();     
        }

    }
    class Test
    {
        public double Perimeter(double r)
        {
            double p = 2 * Math.PI * r;
            return p;
        }
        public double S(double r)
        {
            double s = r * Math.PI * r;
            return s;
        }
        public double V(double r)
        {
            double v = (4*Math.PI*r*r*r)/3;
            return v;
        }
    }
}
