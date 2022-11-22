using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class staticclass
    {
        public static void test(int x)
        {
            Console.WriteLine("sravani");
        }
        public static void test1()
        {
            Console.WriteLine("i love food");
        }
        public static void test3()
        {
            Console.WriteLine("enter a value:");
            var a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value:");
            var b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c value:");
            var c1 = Convert.ToInt32(Console.ReadLine());
            var d = (a1 + b1 + c1) / 3;
            Console.WriteLine("average of 3 numbers is:" + d);


        }
    }
}
