using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace Car
{
    public class CarDocs
    {
        public string InsuranceNr;
        List<string> PreviousOwners = new List<string>();

        //1 Create list of owners


        //2 constructor for insr nr
        //3 run everything


        public void ListOfPreviousOwners()
        {
            PreviousOwners.Add("Pelle");
            PreviousOwners.Add("Kalle");
            PreviousOwners.Add("Petra");

            foreach (string owner in PreviousOwners)
            {
                Console.WriteLine($"Previous owners are: {owner}");
            }
        }


        public CarDocs()
        {
        }

        public CarDocs(string insurance)
        {

            InsuranceNr = insurance;
            Console.WriteLine($"Insurance nr is: {insurance}");
        }

        public static void RunInsurance()
        {
            CarDocs cd = new CarDocs("1234");
            cd.ListOfPreviousOwners();
        }
  
    }
}
