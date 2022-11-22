using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class even
    {
        public static void ev()
        {
            Console.WriteLine("enter a number:");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("it is even number");
            }
            else
            {
                Console.WriteLine("it id odd number");
            }
        }
    }
}
