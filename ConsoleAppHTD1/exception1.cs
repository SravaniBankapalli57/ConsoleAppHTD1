using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class exception1
    {
        public static void div()
        {
        TryAgain:
            try
            {
                Console.WriteLine("Enter x Val:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y Val:");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Div is:" + z);
            }
            catch (Exception ex)
            {
                Console.WriteLine("throw an error-->" + ex.Message);
                goto TryAgain;
            }
        }
    }
}
