using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    class FixityEMpDetails
    {
        public int empid;
        public string empname;
        public string empemail;
        public int empsalary;
        public string empdept;
    }
    internal class fixityempdetails
    {
        public static SortedSet<FixityEMpDetails>getData()
        {
            SortedSet<FixityEMpDetails> obj = new SortedSet<FixityEMpDetails>()
            {
            new FixityEMpDetails{empid=1,empname="sravani",empemail="sravani123@gmail",empsalary=10000,empdept="it" },
            new FixityEMpDetails { empid = 2, empname = "ruby", empemail = "ruby123@gmail", empsalary = 20000, empdept = "hr" }
            };
            return obj;
        }
        public static void Test()
        {
            SortedSet<FixityEMpDetails> obj = getData();
            foreach(var item in obj)

            {
                Console.WriteLine(item.empid+item.empemail+item.empdept);
            }
        }
    }
}
