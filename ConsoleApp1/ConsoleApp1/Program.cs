using ConsoleApp1___9_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1___9_11
{
    //加法
    class Add
    {
        public void Method(int a, int b)
        {
            Console.WriteLine("业务" + a + "+" + b + "=" + (a + b));
        }
    }
    class Subtraction
    {
        public void Method2(int a, int b)
        {
            Console.WriteLine("业务" + a + "-" + b + "=" + (a - b));
        }
    }
    class Multiplication
    {
        public void Method3(int a, int b)
        {
            Console.WriteLine("业务" + a + "*" + b + "=" + (a * b));
        }
    }
    class Division
    {
        public void Method4(int a, int b)
        {
            Console.WriteLine("业务" + a + "/" + b + "=" + (a / b));
        }
    }
    class Operationg
    {
       Add add=new Add();
        Subtraction subtraction = new Subtraction();
        Multiplication multiplication = new Multiplication();
        Division division = new Division();


        public void Fun(int a, int b, int c)
        {
            switch (c)
            {
                case 0:
                    add.Method(a, b);
                    break;
                case 1:
                    subtraction.Method2(a, b);
                    break;
                case 2:
                    multiplication.Method3(a, b);
                    break;
                case 3:
                    division.Method4(a, b);
                    break;
                default: 
                    break;
            }

        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            //  客户端
            while (0==0) 
            {
                Console.WriteLine("输入A");
                int a = int.Parse(s: Console.ReadLine());
                Console.WriteLine("输入B：");
                int b = int.Parse(s: Console.ReadLine());
                Console.WriteLine("输入C：");
                int c = int.Parse(s: Console.ReadLine());
                Operationg operationg = new Operationg();
                operationg.Fun(a, b, c);
            }
        }
    }
}
