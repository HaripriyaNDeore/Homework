using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class Area
	{
		static void Main(string[] args)
		{
			int side, b, height, length, br,r,Area;
			float pi = 3.14f;
			Console.WriteLine("Press 1 to calculate area of Square\n");
			Console.WriteLine("Press 2 to calculate area of right angle triangle\n");
			Console.WriteLine("Press 3 to calculate area of rectangle\n");
			Console.WriteLine("Press 4 to calculate circumference of circle\n");
			Console.WriteLine("Press 5 to calculate Perimeter of a square \n");
			Console.WriteLine("Enter your choice:\n");
			Area = Convert.ToInt32(Console.ReadLine());

			switch (Area)
			{
					case 1:
						Console.WriteLine("Enter side to calculate area of Square ");
						side = Convert.ToInt32(Console.ReadLine());
						int areasqu = side * side;
						Console.WriteLine("area of Square is  " + areasqu);
						break;
					case 2:
						Console.WriteLine("Enter base to calculate area of right angle triangle ");
						b = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter height to calculate area of right angle triangle ");
						height = Convert.ToInt32(Console.ReadLine());
						int arearat = b*height;
						Console.WriteLine("area of right angle triangle is  " + arearat);
						break;
					case 3:
						Console.WriteLine("Enter base to calculate area of area of rectangle ");
						br = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter height to calculate area of rectangle ");
						length = Convert.ToInt32(Console.ReadLine());
						int rectare = br * length;
						Console.WriteLine("area of rectangle is  " + rectare);
						break;
					case 4:
						Console.WriteLine("Enter radius to calculate circumference of circle ");
						r = Convert.ToInt32(Console.ReadLine());
					    Console.WriteLine("area of right angle triangle is  " + 2*pi*r);
						break;
					case 5:
						Console.WriteLine("Enter length of any one side ");
						side = Convert.ToInt32(Console.ReadLine());
						int perisqu = 4 * side;
						Console.WriteLine("Perimeter of square  " + perisqu);
						break;

				default:
						Console.WriteLine("Error");
						break;

			}
			Console.Read();


		}
	}
}
