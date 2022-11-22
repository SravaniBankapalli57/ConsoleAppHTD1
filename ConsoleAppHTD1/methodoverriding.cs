using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    class Chocolate
    {
        public virtual void Flavours()
        {
            Console.WriteLine("This Method Describes the Flavours of Chocolate");
        }
    }
    class bubbly : Chocolate
    {
        public override void Flavours()
        {
            Console.WriteLine("The Flavours of Chocolate is bubbly");
        }
    }
    class Mousey : Chocolate
    {
        public override void Flavours()
        {
            Console.WriteLine("The  Flavours of Chocolate is  Mousey");
        }
    }   }
      internal class methodoverriding
      {

           public static void main()
           {
        
        
           }
      }



