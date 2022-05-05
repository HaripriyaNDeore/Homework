using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Volume
    {
        public void volume(double r)
        {
            double v = (4 / 3) * (22 / 7 )*( r * r * r);
            Console.WriteLine("the volume of sphere " + v );
        }
        public void volume(double h, double r)
        {
            double v = 22 / 7 * (r * r) * h;
            Console.WriteLine("the volume of a cylinder " + v);
        }
        public void volume(double l, double b, double h)
        {
            double v = l * b * h;
            Console.WriteLine("the volume of a cuboid " + v);
        }
        static void Main(string[] args)
        {
            Volume a = new Volume();
            a.volume(3);
            a.volume(5, 4);
            a.volume(5,3,5);


            Console.WriteLine("Enter the radius to calculate volume of sphere ");
            double sphere = Convert.ToDouble(Console.ReadLine());
            a.volume(sphere);
            Console.WriteLine("Volume of sphere is " + sphere);

            Console.WriteLine("Enter the height and radius to calculate volume of cylinder ");
            double height = Convert.ToDouble(Console.ReadLine());
            double radius = Convert.ToDouble(Console.ReadLine());
            a.volume(height, radius);
            Console.WriteLine("Volume of sphere is " + height, radius);

            Console.WriteLine("Enter the l,b,h to calculate volume of cuboid ");
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            a.volume(l,b,h);

            Console.WriteLine("Volume of cuboid is " + l,b,h);
            Console.Read();
        }
    }
}
