using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class predefgeneric1
    {
        public static void Test()
        {
            HashSet<string> obj = new HashSet<string>();
            obj.Add("sravani");
            obj.Add("akhil");
            obj.Add("preethi");
            obj.Add("suma");
            obj.Add("jaggu");
            obj.Add("vasu");
            foreach(string item in obj)
            {
                Console.WriteLine(item);
            }

            Stack<string> obj1 = new Stack<string>();
            
        }
    }
}
