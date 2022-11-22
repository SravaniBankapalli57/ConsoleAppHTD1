using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{ 
        class DemoGenerics
        {
            public static void add(string x,int y)         
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            public static void EmpDetails<val1>(val1 x)
            {
                Console.WriteLine(x);
            }
            public static void EmpDetails<val1, val2>(val1 x, val2 y)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            public static void M1<t1, t2, t3>(t1 x, t2 y, t3 z)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
            }

        }
       
        internal class Generics
    {
        public static void Test()
        {
            DemoGenerics.M1<int, string, float>(12, "Test", 12.25f);
            DemoGenerics.add("sravani", 20);
            DemoGenerics.EmpDetails<string>("iam sravani");
            DemoGenerics.EmpDetails<float, int>(20.9f, 56);
        }

    }
}
