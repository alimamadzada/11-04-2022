using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomework.Models
{
    class Car : MotoredVehicle
    {
        public Car()
        {
        }
        

        public bool IsOn;


        public bool TurnOn()
        {
            this.IsOn = true;

            return this.IsOn;
        }
        public bool TurnOff()
        {
            this.IsOn = false;

            return this.IsOn;
        }
        public void Go(int Distance)
        {
            GetDetailedInfo();
            if (TurnOn())
            {
                if (FuelUsedPerKm > 0 && Distance <= FuelTankSize / FuelUsedPerKm)
                {

                    Console.WriteLine(Distance + " KM mesafe qet olundu");
                    Console.WriteLine(  );
                    Console.WriteLine(FuelTankSize / FuelUsedPerKm + " KM mesafe gede biler");
                }
                else
                    Console.WriteLine("Kifayet qedder yanacaq yoxdur");
            }
            else if (TurnOff())
                Console.WriteLine("Mashin gede bilmez");
        }

        public Car(string Model, string Make, string ProductionYear) : base(Model, Make, ProductionYear)
        {

        }

    }
}
