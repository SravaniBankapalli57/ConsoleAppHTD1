using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class cent
    {
        public static void Dollars()
        {
            double dollar, cents;
            Console.Write("Enter dollar amount :");
            dollar = Convert.ToDouble(Console.ReadLine());
            cents = (dollar * 100);
            Console.WriteLine("the cents are=" + cents);
        }
    }
}
