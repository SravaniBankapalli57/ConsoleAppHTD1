using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    abstract class Addition
    {
        public abstract void add();
    }

    class Subraction : Addition
    {
        public override void add()
        {

            Console.WriteLine("a+b or a-b");

        }
    }
    internal class abstractclass
    {
    }
}
