using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Day1
    {
        public static void str()
        {
            
            Console.WriteLine("enter a name:");
            string str = Console.ReadLine();
           
            char[] a = str.ToCharArray();
            for(int i=a.Length-1;i>=0;i--)
                
            {
                Console.Write(a[i]);
            }
            Console.WriteLine(" ");
        }
        public static void strcou()
        {
            Console.WriteLine("enter a string:");
            string s = Console.ReadLine();
            while(s.Length>0)
            {
                Console.Write(s[0]+"=");
                int count = 0;
                for(int i=0;i<s.Length;i++)
                {
                    if (s[0] == s[i])
                    {
                        count++;
                    }
                   
                }
                Console.WriteLine(count);
                s=s.Replace(s[0].ToString(), String.Empty);
            }
        }
        public static void dtob()
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
        public static void sum()
        {
            int n,rem, sum = 0;
            Console.WriteLine("enter a number:");
             n = int.Parse(Console.ReadLine());
            while(n>0)
                  {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;

            }
            Console.WriteLine(sum);
        }
        public static void rev()
        {
            int n;
            //Console.WriteLine("enter a number:");
            //n = int.Parse(Console.ReadLine());
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void btod()
        {
            int rem, sum = 0, b = 1;
            Console.WriteLine("enterb a number:");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem * b;
                n = n / 10;
                b = b * 2;
            }
            Console.WriteLine(sum);
        }
    }
}
