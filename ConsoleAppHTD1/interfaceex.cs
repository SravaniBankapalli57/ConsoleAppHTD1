using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    interface x1
    {
        void test1();
    }
    interface x2
    {
        void test2();
    }
    internal class interfaceex:x1,x2
    {
        public void test1()
        {
            Console.WriteLine("test1 is first");
        }
    public void test2()
        {
            Console.WriteLine("test2 is second");
        }
    }
}
