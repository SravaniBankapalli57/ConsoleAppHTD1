using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Day2
    {
        public static void Dublicate()
        {
            string s = Console.ReadLine();
            string r = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (!r.Contains(s[i]))
                {
                    r = r + s[i];
                }
            }
            Console.WriteLine(r);
        }
        public static void substring()
        {
            Console.Write("Enter a String : ");
            string str = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < str.Length; ++i)
            {

                for (int j = i; j < str.Length - i; j++)
                {

                    Console.WriteLine(str.Substring(i, j + 1));

                }
            }

        }
        public static void Reverse()
        {
            Console.Write("Enter a String : ");
            string s = Console.ReadLine();
            string str = " ";

            foreach (var word in s.Split(' '))
            {
                string item = " ";
                foreach (var ch in word.ToCharArray())
                {

                    item = ch + item;
                }
                str = str + item;
            }
            Console.WriteLine(str + " ");
        }


        public static void TDOD()
        {
            Console.Write("Enter no of rows");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter no of coloumns");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[,] b = new int[n, m];
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}] : ", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }
            int i, j, k = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    k = i * m + j;
                    a[k] = b[i, j];
                    k++;
                }
            }



            // displaying elements in 1-d array
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + " ");
            }
        }
        public static void OTT()
        {
            int i;
            Console.WriteLine("Enter no of rows:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of cloumns:");
            int n = int.Parse(Console.ReadLine());
            int c = m * n;
            int[] a = new int[c];
            for (i = 0; i < c; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < c; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int[,] b = new int[m, n];
            int k, l, z = 0;
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    z = k * m + l;
                    b[k, l] = a[z];
                    z++;
                }



            }
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    Console.Write(b[k, l] + " ");
                }
                Console.WriteLine();
            }
        }




    }
}


