﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class factorial
    {
        public static void fact()
        {
            int i, fact = 1, number;
            Console.WriteLine("enter a number:");
            number = int.Parse(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                fact = fact * i;
               
            }
            Console.WriteLine("factorial of " + number + "is:" + fact);
        }
    }
}
