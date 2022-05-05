using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Voter
    {
        long adharcard;
        string votername;
        string votergiven;

        public void SetAdharCard(long ACard)
        {
            adharcard = ACard;
        }
        public long GetAdharCard()
        {
            return adharcard;
        }
        public void SetVoterName(string VName)
        {
            votername = VName;
        }
        public string GetVoterName()
        {
            return votername;
        }
        public void Setvotergiven(string VGiven)
        {
            votergiven = VGiven;
        }
        public string Getvotergiven()
        {
            return votergiven;
        }
        static void Main(string[] args)
        {
            Voter v = new Voter();
            v.SetAdharCard(232345422354);
            v.SetVoterName("Priya");
            v.Setvotergiven("BJP");

            long no= v.GetAdharCard();
            Console.WriteLine("Adhar Card "+no);
            string vname = v.GetVoterName();
            Console.WriteLine("Voter Name "+vname);
            string vgiven = v.Getvotergiven();
            Console.WriteLine("Vote Given To "+vgiven);

            Console.WriteLine("Enter AdharCard,VoterName,VoterGiven");
            long adharcard = Convert.ToInt64(Console.ReadLine());
            string votername = Convert.ToString(Console.ReadLine());
            string votergiven = Convert.ToString(Console.ReadLine());
            Console.WriteLine(adharcard);
            Console.WriteLine(votername);
            Console.WriteLine(votergiven);
            Console.ReadLine();


        }
    }
}
