using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Seal
    {
        public virtual void play()
        {
            Console.WriteLine("playground");
        }
        public virtual void study(int n)
        {
            Console.WriteLine("study hours "+n);
        }
    }
    sealed class Seal1:Seal
    {
        public void play()
        {
            Console.WriteLine("Play Video game");
        }
        public void study(int n)
        {
            Console.WriteLine($"study by watching video {n} hours");
        }

    }
    class Seal2
    {
        static void Main(string[] args)
        {
            Seal1 s = new Seal1();
            s.play();
            s.study(2);
            Seal ss = new Seal();
            ss.play();
            ss.study(4);
            Console.ReadLine();
        }
    }
}
