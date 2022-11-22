using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class rect
    {
        public static void reactangle()
        {
            double length, width, area;
            Console.WriteLine("Enter a value : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value : ");
            width = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            Console.WriteLine("Area of rectangle: " + area);
        }

       
    }
}
