using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class Salary
	{
        static void Main(string[] args)
        {
            float salary, DA, HRA, gross;
            Console.WriteLine("Enter the salary of employee");
            salary = float.Parse(Console.ReadLine());
            if (salary <= 10000)
            {
                DA = (salary * 80) / 100;
                HRA = (salary * 20) / 100;
                gross = salary + DA + HRA;
                Console.WriteLine("Gross salary is " + gross);
            }
            else if (salary <= 20000)
            {
                DA = (salary * 90) / 100;
                HRA = (salary * 25) / 100;
                gross = salary + DA + HRA;
                Console.WriteLine("Gross salary is " + gross);
            }
            else if (salary > 20000)
            {
                DA = (salary * 95) / 100;
                HRA = (salary * 30) / 100;
                gross = salary + DA + HRA;
                Console.WriteLine("Gross salary is " + gross);
            }
            Console.ReadLine();



        }
    }
}
