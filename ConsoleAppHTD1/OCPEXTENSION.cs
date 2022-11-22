using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal static class OCPEXTENSION
    {
        public static void test(this SRPMATHFUN obj)
        {
            Console.WriteLine("this class test is extension from the SRPMETHFUN");
        }
    }
}
