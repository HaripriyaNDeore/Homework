using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework.SimpleProgram
{
    class AccessModifier1
    {
        int studid;
        string studname;
        
        public AccessModifier1()
        {

        }

        public AccessModifier1(int studid, string studname)
        {
            this.Studid = studid;
            this.Studname = studname;
        }

        public int Studid { get => studid; set => studid = value; }
        public string Studname { get => studname; set => studname = value; }
        static void Main(string[] args)
        {
            
        }
    }
}
