using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class CountNoOfVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            String str = Console.ReadLine();
            int vowel = 0;

            for (int i = 0; i < str.Length; i++)
            {
               
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e'|| str[i] == 'E' || str[i] == 'i'||str[i] == 'I' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u'|| str[i] == 'U')
                {
                   vowel++;
                }
            }
            Console.WriteLine("Total number of vowels: "+vowel);
            Console.ReadLine();
        }
    }
}
