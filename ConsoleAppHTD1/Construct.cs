using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Construct
    {
        public Construct()
        {
            int x = 40, y = 30, z;
            z = x * y;
            Console.WriteLine("value is="+z);
        }
        public Construct(int x)
        {
            Console.WriteLine("hi this is sravani:)");
        }
        public Construct(int x,int y)
        {
            int z;
           
            z = x % y;
            Console.WriteLine("value is="+z);

        }
    }
}
