using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Class1
    {
        public static void fact()
        {
            int i;
            long fact = 1;
            Console.WriteLine("enter a number:");
            long num = int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                fact = fact * i;
                
            }
            Console.WriteLine("factorial of number is" + fact);
        }
    }
}
