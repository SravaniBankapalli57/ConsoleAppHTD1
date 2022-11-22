using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
     class inheritance
    {
       
        public static void add()
        {
           int x = 30;int y=60;
            int z = x + y;
            Console.WriteLine("Addition is="+z);
        }
     }
    class inheritance1 : inheritance
    {
        public static void sub()
        {
            
            int x1 = 30; int y1 = 60;
            int z1 = x1 - y1;
            Console.WriteLine("subraction is=" + z1);
        }
    }
    
}
