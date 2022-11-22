using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class practice
    {
        public static void pract()
        {
            Console.WriteLine("enter a number:");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter b value:");
            float b= Convert.ToSingle(Console.ReadLine());
            var c= a * b;
            Console.WriteLine("the value is ="+ c);
        }


    }
}
