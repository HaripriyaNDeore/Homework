using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class ReverseTheGivenArray
    {
        static void Main(string[] args)
        {
            int[] Arr = { 3, 90, 45, 29, 37, 78 };
            Console.WriteLine("Given Array is ");
            Console.WriteLine(" ");
            for(int i=0;i<Arr.Length;i++)
            {
                Console.Write(Arr[i]+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("After reversing it output is");
            Console.WriteLine(" ");
            for(int j=Arr.Length-1;j>=0;j--)
            {
                Console.Write(Arr[j]+" ");
            }
            Console.ReadLine();
        }
    }
}
