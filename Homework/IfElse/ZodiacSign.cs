using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
    class ZodiacSign
    {
        static void Main(string[] args)
        {
            int day, month;
            Console.WriteLine("Enter Your Birthdate");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Birth Month");
            month = Convert.ToInt32(Console.ReadLine());
          
            if((month==3 && day>=21)||(month==4 && day<=19))
            {
                Console.WriteLine("Your Zodiac Sign is Aries");
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                Console.WriteLine("Your Zodiac Sign is Taurus");
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                Console.WriteLine("Your Zodiac Sign is Gemini");
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                Console.WriteLine("Your Zodiac Sign is Cancer");
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                Console.WriteLine("Your Zodiac Sign is Leo");
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                Console.WriteLine("Your Zodiac Sign is Virgo");
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                Console.WriteLine("Your Zodiac Sign is Libra");
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                Console.WriteLine("Your Zodiac Sign is Scarpio");
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                Console.WriteLine("Your Zodiac Sign is Sagittarius");
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                Console.WriteLine("Your Zodiac Sign is Capricorn");
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                Console.WriteLine("Your Zodiac Sign is Aquarius");
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                Console.WriteLine("Your Zodiac Sign is Pisces");
            }
            else
            {
                Console.WriteLine("Invalid date");
            }
            Console.Read();


        }
    }
}
