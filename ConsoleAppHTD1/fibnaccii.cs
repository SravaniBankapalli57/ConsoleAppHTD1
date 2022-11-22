using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class fibnaccii
    {
        public static void fib()
        {
            int i1 = 0, i2 = 1, i3, n, number;
            Console.WriteLine("enter the number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            for (n = 2; n <= number; n++)
            {
                i3 = i1 + i2;
                Console.WriteLine(i3 + "");
                i1 = i2;
                i2 = i3;
            }
        }
        public static void prime()
        {
            int i, num, a = 0;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("not a prime number");
            }

        }
        public static void swap()
        {
            int a = 40, b = 50;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
        public static void strong()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.Write("Armstrong Number.");
            }
            else
            {
                Console.Write("Not Armstrong Number.");
            }

        }
        public static void fact()
        {
            int i, fact = 1, number;
            Console.WriteLine("enter a number:");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("factorial of " + number + "is:" + fact);
        }
    }
}
