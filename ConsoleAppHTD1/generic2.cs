using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    class DemoGen<t1, t2>
    {
        public void add(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void sub(t1 x, t2 y)
        {
        }
        public void mul(t1 x, t2 y)
        {
        }
        public void div(t1 x, t2 y)
        {
        }
        public void area(t1 x, t2 y)
        {
        }
        public void M1(t1 x)
        {
            Console.WriteLine("m1 is:" + x);
        }

    }
   
    internal class generic2
    {
        public static void Test()
        {
            DemoGen<int, int> obj = new ConsoleAppHTD1.DemoGen<int, int>();
            obj.add(12, 45);
            obj.M1(12);
        }
    }
}
