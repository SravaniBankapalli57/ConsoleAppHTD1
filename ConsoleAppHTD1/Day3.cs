using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Day3
    {
        public static void removeduplicates()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            int i, j;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(a[i] + " ");
                    if (a[j] == a[i])
                        break;
                }
            }
            Console.WriteLine();
        }



        public static void Ang()
        {
            Console.Write("Enter Hours : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md = m * 6;
            double diff = Math.Abs(hd - md);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {h} hour and {m} minute is {diff} degrees");
        }



        public static void DN()
        {
            int n = int.Parse(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    a = 1;
                    break;
                }
                n =n/ 10;
            }
            if (temp > 0 && a == 1)
            {
                Console.WriteLine("Given Number is a Duck Number");
            }
            else
            {
                Console.WriteLine("Given Number is not a Duck Number");
            }
        }



        public static void RightRotation()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n - 1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Right circular rotation   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void LeftRotation()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n - 1; j++)
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Left circular rotation   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Dublicate()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            int i, j;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(a[i] + " ");
                    if (a[j] == a[i])
                        break;
                }
                //if (n == j)
                //{
                //    Console.Write(a[i] + " ");
                //}
            }
            Console.WriteLine();
        }
    }
}