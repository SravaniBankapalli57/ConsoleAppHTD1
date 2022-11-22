using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void CallingAdd();
public delegate int Callingsub(int x, int y);

namespace ConsoleAppHTD1
{
    class deligatedemo
    {
            public void Add()
            {
            Console.WriteLine("add");
            }
        public static int sub(int x, int y)
        {
            Console.WriteLine(x - y);
            return x;
        }
            public static string Name()
            {
                Console.WriteLine("my name is sravani");
            return "";
            }
        }
        
    
    internal class deligateex
    {
        public static void Test()
        {
            
            deligatedemo d1 = new deligatedemo();
            CallingAdd obj = new CallingAdd(d1.Add);
            obj();
            Callingsub obj1 = new Callingsub(deligatedemo.sub);
            obj1(78, 12);




        }
    }
}
