using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Country
    {
        string countryname;
        int noofstates;
        int nooflanguage;
        string capital;

        public string CountryName
        {
            get
            {
                return countryname;
            }
            set
            {
                countryname = value;
            }
        }
        public int NoofStates
        {
            get
            {
                return noofstates;
            }
            set
            {
                noofstates = value;
            }
        }
        public int NoofLanguage
        {
            get
            {
                return nooflanguage;
            }
            set
            {
                nooflanguage = value;
            }
        }
        public string Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
            }
        }
       
    }
    class Country1
    {
        static void Main(string[] args)
        {
            Country c = new Country();
            c.CountryName = "India";
            Console.WriteLine(c.CountryName);
            c.Capital = "Delhi";
            Console.WriteLine(c.Capital);
            c.NoofLanguage = 121;
            Console.WriteLine(c.NoofLanguage);
            c.NoofStates = 28;
            Console.WriteLine(c.NoofStates);
            Console.ReadLine();


        }

    }


}
