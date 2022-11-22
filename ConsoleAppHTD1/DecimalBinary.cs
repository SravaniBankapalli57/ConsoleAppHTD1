using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class DecimalBinary
    {
        public static void Test()
        {
            int n, i;


            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine()); //52
            for (i = 0; n > 0; i++) 
            {
                a[i] = n % 2;
                n = n / 2;
                Console.WriteLine(a[i]);
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
