using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class methodoverloading
    {
        public void M1()
        {
            Console.WriteLine("task 1");
        }
        public void M1(int x)
        {
            Console.WriteLine("task 2 with 1 int parameter");
        }
        public void M1(int x, int y)
        {
            Console.WriteLine("task 3 with 2 parameters");
        }
       
    }
}
