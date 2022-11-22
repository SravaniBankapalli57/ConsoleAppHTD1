using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class staticconstruct
    {
        static staticconstruct()
        {
            Console.WriteLine("enter a number:");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("it is even number");
            }
            else
            {
                Console.WriteLine("it id odd number");
            }
        }
       public staticconstruct(int x,int y)
        {
            int z;
            z = x + y;
            Console.WriteLine("the value="+z);
        }

        public staticconstruct(int x)
        {
            Console.WriteLine("hello everyone:)");
        }
       
           

        
        

           
    }
}
