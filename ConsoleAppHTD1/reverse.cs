﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class reverse
    {
     public static void rev()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
                Console.WriteLine("Reversed Number is:" + reverse);
            }
        }
    }
}
