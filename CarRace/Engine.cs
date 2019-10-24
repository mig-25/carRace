using System;
namespace Car
{
    public class Engine
    {
        public static string Size;
        public static int HorsePower;
        public static float FuelConsumtionRate;

        //Constructor to set fuel reate
        public Engine(float fuelRate)
        {
            FuelConsumtionRate = fuelRate;
        }
        public Engine(string cylinder, int hp, float fuelRate)
        {
            Size = cylinder;
            Console.WriteLine($"Engine type: {cylinder}");
            HorsePower = hp;
            Console.WriteLine($"Horse power: {hp} hp");
            FuelConsumtionRate = fuelRate;
            Console.WriteLine($"Fuel consumption: {fuelRate} l/h");
        }
        

   
       //Engine v4 = new Engine("v4", 200, 0.7);

       //Engine v6 = new Engine("v6", 300, 4.1);

       //Engine v8 = new Engine("v8", 400, 3.1);

   
   

    }
}
