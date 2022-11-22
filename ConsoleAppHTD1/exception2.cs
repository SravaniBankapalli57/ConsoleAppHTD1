using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class exception2
    {
        public void Method()
        {
            try
            {
                int x = 0;
                int sum = 100 / x;
            }
            catch (DivideByZeroException ex)
            {
                throw;
            }
        }
    }
}