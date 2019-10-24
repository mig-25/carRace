using System;

namespace Car
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*
            //How do I get the engine size in the constructor here?
            CarEx car = new CarEx("Saab", 10, "1234DD", "v4");
            car.SwitchOn();
            car.Accelerate();
            */



            //I would rather instantiate this in the class itself with a method
            //Engine.CreateEngine();

            CarEx.RunCar();

            
           

        }
    }
}
