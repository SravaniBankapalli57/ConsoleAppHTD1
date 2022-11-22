using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Exclass
    {
        public int x, y, z;
        public void add()
        {
            int x = 50; int y = 90;
            int z = x + y;
            Console.WriteLine("addition is="+z);
        }
        public void mul()
        {
            int x = 50; int y = 90;
            int z = x * y;
            Console.WriteLine("multification is=" + z);
        }
    }
    class prevclass: Exclass
    {
        public int x, y, z;
        public void sub()
        {
            add();
            mul();
            int x = 50; int y = 90;
            int z = x - y;
            Console.WriteLine("substraction is=" + z);
        }
        public void div()
        {
            int x = 50; int y = 90;
            int z = x / y;
            Console.WriteLine("division is=" + z);
        }
    }

}
