using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class LSPEX
    {
        public void add()
        {
            
            Console.WriteLine("Here we can use addition");
        }
        public void mul()
        {
            Console.WriteLine("Here we can use multiplication");
        }
    }
        class LSPEX1 : LSPEX
        {
            public void add1()
            {
                add();
                mul();
                int x = 50; int y = 40;
                int z = x + y;
                Console.WriteLine("addition is=" + z);
            }
            public void mul1()
            {
                int x = 50; int y = 40;
                int z = x * y;
                Console.WriteLine("multiplication is=" + z);
            }
        }
    
}
