using System;
namespace Car
{
    public class CarEx
    {
        string Manfacturer { get; set; }
        string RegistrationNr { get; set; }
        float Fuel;
        float Speed;
        bool IsRunning;

        public CarEx(string manuf, float fuel, string regNr)
        {
            Manfacturer = manuf;
            this.Fuel = fuel;
            RegistrationNr = regNr;
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine($"Manufacturer; {manuf}, Fuel amount: {fuel}l, License: {regNr}");
            Console.WriteLine("______________________________________________________");
        }

        public void ChooseEngineType()
        {
            Engine v4 = new Engine("v4", 200, 0.7f);

        }

        public void CallCustomer()
        {
            Owner.runOwner();
            ChooseEngineType();
        }

        public void SwitchOn()
        {
            IsRunning = true;
        }

        public void SwitchOff()
        {
            IsRunning = false;
            Speed = 0;
        }

        public void Accelerate()
        {

            if (!IsRunning)
            {
                return;
            }


            /*
            //Syntax issue, if signal status is not true, return
            if (!TrafficSignal.CheckValidSignal())
            {
                return;
            }
            */

            Console.WriteLine("____________________________");
            Console.WriteLine("START");
            Console.WriteLine("____________________________");

            for (int i = 1; i <= 20; i++)
            {
                Dashboard();

                if (Speed > 0 || Fuel < 0)
                {
                    Console.WriteLine($"{i} Accelrating");
                }
                else
                    Console.WriteLine($"{i} Vehicle stationary");

                Speed += 6.0f;
                /*Using fuel rate from v4 object of Engine instantiated on line 25 
                 */

                Fuel -= Engine.FuelConsumtionRate;

                while (Fuel < 5)
                {
                    SwitchOff();
                    Console.WriteLine("___________________________________");
                    Console.WriteLine($"WARNING!!! Fuel level critical");
                    Console.WriteLine($"Please fill upp");

                    Console.WriteLine($"Current fuel amount: {Fuel.ToString("F2")}l");
                    Console.Write($"Refuel amount?");
                    float FuelAmount = Convert.ToInt32(Console.ReadLine());
                    Fuel += FuelAmount;
                    //FillFuel(50);
                    Console.WriteLine($"Fuel after refueling {Fuel.ToString("F2")}l");
                    Console.WriteLine("___________________________________");
                    SwitchOn();
                }

                if (Speed >= 60)
                {
                    Break();
                    Console.WriteLine($"WARNING!!!, OVERSPEED, BREAKING...");
                    Console.WriteLine("___________________________________");
                }

            }


        }


        public void Break()
        {
            Speed = 0;
        }

        public void Dashboard()
        {
            Console.WriteLine($"Velocity: {Speed}km/h");
            Console.WriteLine($"Fuel: {Fuel.ToString("F2")}l");
        }

        public void FillFuel(float amount)
        {
            Fuel += amount;

        }

        public float GetFuel()
        {
            return Fuel;
        }

        public float GetSpeed()
        {
            return Speed;
        }

        public static void RunCar()
        {
            CarEx car1 = new CarEx("Saab", 10, "1234DD");
            //CarEx car1 = new CarEx();
            //car1.Manfacturer = "Saab";
            //car1.RegistrationNr = "12345SE";

            //car1.FillFuel(10);
            car1.CallCustomer();
            Console.WriteLine($"Maker: {car1.Manfacturer}");
            Console.WriteLine($"Registration nr: {car1.RegistrationNr}");
            car1.SwitchOn();
            car1.Accelerate();
        }
    }
}
