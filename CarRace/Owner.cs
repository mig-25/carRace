using System;
namespace Car
{
    public class Owner
    {
        public string OwnerName;

        public Owner()
        {
        }

        public Owner(string Owner)
        {
            OwnerName = Owner;
            Console.WriteLine($"Owner: {Owner}");
        }

        public static void runOwner()
        {
            Owner driver = new Owner("Sohail");
            CarDocs.RunInsurance();
        }

        


    }
}
