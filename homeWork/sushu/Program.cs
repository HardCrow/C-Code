using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sushu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            int j = 0;
            for (i = 2; i <= 100; i++)
            {
                for (k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        break;
                    }
                }
                if (k == i)
                {
                    Console.Write(" {0} ", i);
                    j++;
                }
              
            }
            Console.ReadLine();
        }
    }
}
