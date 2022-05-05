using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Area
    {
        public void area(float x)
        {
            Console.WriteLine("the area of the square is " + x * x);
        }
        public void area(float x, float y)
        {
            Console.WriteLine("the area of the rectangle is " + x * y);
        }
        public void area(int x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle is " + z );
        }

        static void Main(string[] args)
        {
            Area a = new Area();
            a.area(4);
            a.area(5, 5);
            a.area(5);
            Console.Read();

        }
    }
}
