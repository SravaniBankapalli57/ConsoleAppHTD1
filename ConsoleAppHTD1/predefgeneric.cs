using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class predefgeneric
    {
        public static void Test()
        {
            List<int> obj = new List<int>();//it add,remove and also have duplicates
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(4);
            obj.Add(5);
            obj.Add(6);
            obj.Remove(6);

            SortedSet<int> obj1 = new SortedSet<int>();//it can add remove but not have duplicates
            obj1.Add(1);
            obj1.Add(2);
            obj1.Add(3);
            obj1.Add(4);
            obj1.Add(5);
            obj1.Add(1);
            obj1.Add(2);
            obj1.Add(3);
            obj1.Add(4);
            obj1.Add(5);
            
            foreach (var item in obj)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
