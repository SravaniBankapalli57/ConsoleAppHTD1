using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class greatest
    {
        public static void great()
        {
            Console.WriteLine("enter a value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c value:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("a is greater");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }

        }

    }
}
