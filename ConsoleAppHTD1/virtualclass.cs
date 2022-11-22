using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    public class numbers
    {
        public virtual void addition()
        {
            Console.WriteLine("This is addition method");
        }

        public virtual void subtraction()
        {
            Console.WriteLine("This is subtraction method");
        }

    }

    public class calculate : numbers
    {
        public override void addition()
        {

            Console.WriteLine("This is addition method in the derived class");
        }

        public override void subtraction()
        {

            Console.WriteLine("This is subtraction method override in derived class");
        }
    }
    internal class virtualclass
    {
    }
}
