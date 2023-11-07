using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20207124 黄英杰");
            for (int i = 0; i < 10; i++)
            {
                Singler.GetSingler().Show(); 
            }
          
            for (int i = 0; i < 10; i++)
            {
                singlerTwo.GetSinglerTwo().Show();
                  
            }
            Console.ReadLine();
        }
    }
}
