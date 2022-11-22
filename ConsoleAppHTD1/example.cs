using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    
        class example
        {
            public int Eid;
            public string Name;
            public string Email;
            public int Salary;
            public string Dept;
        }
        internal class ListExample2
        {
            public static List<example> getData()
            {
                List<example> obj = new List<example>()
            {
            new example{ Eid=1,Name="Raj",Email="Raj@yahoo.com",Salary=1000,Dept="IT"},
            new example{ Eid=2,Name="anu",Email="anu@yahoo.com",Salary=2000,Dept="HR"},
            new example{ Eid=3,Name="khan",Email="khan@yahoo.com",Salary=30000,Dept="Sales"}
            };
                return obj;
            }
            public static void Test()
            {
                List<example> obj = getData();
                foreach (var item in obj)
                {
                    Console.WriteLine(item.Eid + item.Name+item.Email+item.Salary);
                }
            }
        }
}
