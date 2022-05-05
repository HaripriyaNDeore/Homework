using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class SearchPosition
    {
        static void Main(string[] args)
        {
            int[] SeaArr = { 1, 6, 5, 9, 2, 7, 3 };
            Console.WriteLine("Enter the search element");
            int ele = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<SeaArr.Length;i++)
            {
                if(SeaArr[i]==ele)
                {
                    Console.WriteLine("Element found at "+i+" position");
                }
            }
            Console.ReadLine();
        }
    }
}
