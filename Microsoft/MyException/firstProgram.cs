using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.MyException
{
    class firstProgram
    {
        static void Main(string[] args)
        {
            
            try
            {
                string s;
               
                Console.WriteLine("Enter 1st number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2st number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division " + a / b);
               
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Please enter the stirng");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("we cant divide it by zero");
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}
