using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class PermanantTeacher:Teacher
    {
        string subject;
        public PermanantTeacher()
        {
            Console.WriteLine("In Permanant Teacher Default Constructor");
        }
        public PermanantTeacher(string subject)
        {
            this.subject = subject;
        }
        public string Subject { get => subject; set => subject = value; }
    }
}
