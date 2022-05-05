using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Classwork.Collection
{
    class BasicArraLisFu1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);
            al.Add("priya");
            al.Add("malegaon");
            al.Add("Nashik");
          
            al.Add(20);
            al.Add("priya@gmail.com");
            al.Remove("malegaon");
            al.Reverse();
            al.Insert(1,"Malegaon");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            for (int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.ReadLine();
                

        }
    }
}
