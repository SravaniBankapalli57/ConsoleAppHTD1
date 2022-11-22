using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void CallZeropmmethod();
public delegate void callpmmethod(int x, int y);

namespace ConsoleAppHTD1
{
    class DelDemo1
    {
        public void add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("the add value is =" + z);
        }
        public void sub(int x, int y)
        {
            int z = x - y;
            Console.WriteLine("the sub value is =" + z);
        }
        public static void div()
        {
            int x = 30;int y = 30;
            int z = x / y;
            Console.WriteLine("the div value is =" + z);
        }
        public static void mul()
        {
            int x = 30; int y = 30;
            int z = x * y;
            Console.WriteLine("the mul value is =" + z);
        }
    }
    internal class DeliDemo
    { 
        public static void Test()
        {
            //singlecast
            CallZeropmmethod obj = new CallZeropmmethod(DelDemo1.div);
            obj();
            //multicast
            CallZeropmmethod obj1= new CallZeropmmethod(DelDemo1.mul);
            obj1 += new CallZeropmmethod(DelDemo1.div);
            obj1();
        }


    }

   
}
