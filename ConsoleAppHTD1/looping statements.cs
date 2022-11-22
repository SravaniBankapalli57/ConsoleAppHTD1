using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class looping_statements
    {
        public static void forloop()
        {
                //1.var initiliaztion 2. condtion 3. incremneting operator
                for (int x = 1; x <= 2; x++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(x);
                    }
                }
        }

        public static void While()
        {
            int x = 10;
            while (x < 10)
            {
                Console.WriteLine("X Value in While Loop:" + x);
                x++;
            }
        }


        public static void DoWhile()
        {
            int x = 10;
            do
            {
                Console.WriteLine("Executing the Statement:" + x);
                x++;
            }
            while (x < 10);
        }
    }
}
