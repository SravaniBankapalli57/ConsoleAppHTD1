using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class ClassDemo
    {
        public  static void add()
        {
            Console.WriteLine("enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value:");
            int b= Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("addition is=" + c);
        }
        public static void div()
        {
            int x = 50;int y = 40;
            int T = x / y;
            Console.WriteLine("division is="+T);
        }
        public static void mul()
        {
            Console.WriteLine("enter a,b values:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("value is="+c);
        }
        public static void sub()
        {
            int x = 4; int y = 2;
            int Z = y - x;
            Console.WriteLine("the value:"+Z);

        }
           

    }
}
