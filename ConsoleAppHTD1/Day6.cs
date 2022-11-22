using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Day6
    {
        public static void VolumeOfCube()
        {
            Console.WriteLine("Enter side of a cube:");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal Volume = a * a * a;
            Console.WriteLine("The volume of cube:" + Volume);
            Console.WriteLine();
        }



        public static void SurfAreaOfCuboid()
        {
            Console.WriteLine("Enter the length of cuboid:");
            decimal l = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter breadth of cuboid:");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the height of cuboid:");
            decimal h = Convert.ToDecimal(Console.ReadLine());
            decimal surfArea = 2 * (l * b + b * h + h * l);
            Console.WriteLine("The surface area of cuboid:" + surfArea);
        }



        public static void VolumeOfCuboid()
        {
            Console.WriteLine("Enter the length of cuboid:");
            decimal l = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter breadth of cuboid:");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the height of cuboid:");
            decimal h = Convert.ToDecimal(Console.ReadLine());
            decimal Volume = l * b * h;
            Console.WriteLine("The surface area of cuboid:" + Volume);
        }



        public static void SurfAreaOfCylinder()
        {
            double PI = 3.14;
            Console.WriteLine("Enter height of cylinder:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius of cylinder:");
            double r = Convert.ToDouble(Console.ReadLine());
            double CSAC = 2 * PI * r * h;
            double TSAC = 2 * PI * r * (r + h);
            Console.WriteLine("The curve surface area of cylinder:" + CSAC);
            Console.WriteLine("The total surface area of cylinder:" + TSAC);
            Console.WriteLine();
        }



        public static void VolumeOfCylinder()
        {
            double PI = 3.14;
            Console.WriteLine("Enter height of cylinder:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius of cylinder:");
            double r = Convert.ToDouble(Console.ReadLine());
            double Volume = PI * r * r * h;
            Console.WriteLine("The volume of Cylinder:" + Volume);
        }
    }
}
