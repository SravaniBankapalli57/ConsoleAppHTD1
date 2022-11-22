using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class pract
    {
        public static void inte()
        {
            int number;
            Console.Write("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered :{0}", number);

        }
        public static void integer()
        {
            Console.WriteLine("enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value:");
            int b = Convert.ToInt32(Console.ReadLine());
            var c = a + b;
            Console.WriteLine("the value is=" + c);

        }
        public static void div()
        {
            int a = 50, b = 10;
            int quotient = a / b;
            int reminder = a % b;

            Console.WriteLine("quotient value is=" + quotient);
            Console.WriteLine("divisor value is=" + reminder);
        }

        public static void interest()
        {
            int P, T;
            float R, SI;
            Console.WriteLine("enter amount:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate:");
            R = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter time:");
            T = Convert.ToInt32(Console.ReadLine());
            SI = P * R * T / 100;
            Console.WriteLine("the interest is=" +SI);

        }
        public static void square()
        {
            int squareheight,area,perimeter;
            Console.WriteLine("enter the height of the square:");
            squareheight = Convert.ToInt32(Console.ReadLine());
            area = squareheight * squareheight;
            perimeter = 4 * squareheight;
            Console.WriteLine("area="+area);
            Console.WriteLine("perimeter="+perimeter);

        }
        public static void circle()
        {
            double r, area, perimeter;
            Console.WriteLine("enter the radius of the circle");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
            Console.WriteLine("area="+area);
            Console.WriteLine("perimeter="+perimeter);

        }
    }
}
