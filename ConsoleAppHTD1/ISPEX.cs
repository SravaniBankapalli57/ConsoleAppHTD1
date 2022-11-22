using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    interface x11
    {
        void test6();
    }
    interface x21
    {
        void test7();
    }
    internal class ISPEX:x11,x21
    {
        public void test6()
            {
                Console.WriteLine("test1 is first");
            }
            public void test7()
            {
                Console.WriteLine("test2 is second");
            }
        
    }

}

