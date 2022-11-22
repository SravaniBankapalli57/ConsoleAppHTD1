using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class atm
    {
        public static void atmcheck()
        {
            int amount = 500, deposite, withdraw;
            int choice, pin = 1576;
            Console.WriteLine("enter your pin:");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.bal checking ");
            Console.WriteLine("2.cash deposite");
            Console.WriteLine("3.withdraw amount");
            Console.WriteLine("4.quit");
            Console.WriteLine("enter your chioce:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("your balance is:"+amount);
                    break;
                case 2:

                    Console.WriteLine("enter the amount to deposite:");
                    deposite = Convert.ToInt32(Console.ReadLine());
                    amount = amount + deposite;
                    Console.WriteLine("your balance is"+amount);
                    break;

                case3:
                    Console.WriteLine("enter the amount to withdraw: ");
                    withdraw = Convert.ToInt32(Console.ReadLine());
                    if ((withdraw > (amount - 500)))
                    {
                        Console.WriteLine("balance is insufficient");
                    }

            }
        }
    }    
}

