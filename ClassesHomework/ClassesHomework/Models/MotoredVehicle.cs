using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomework.Models
{
    class MotoredVehicle
    {
        public string Model;
        public string Make;
        public string ProductionYear;
        public string Color;
        public int MotorSize;
        public int FuelTankSize;
        public int FuelAmount;
        public int FuelUsedPerKm;
        public int Transmission;
        public int HorsePower;
        public int PassangerCount;


        public MotoredVehicle()
        {

        }


        public MotoredVehicle(string Model, string Make, string ProductionYear)
        {
            this.Model = Model;
            this.Make = Make;
            this.ProductionYear = ProductionYear;
        }


        public void GetInfo()
        {
            Console.Write("Mashinin Make'ni qeyd edin: ");
            Make = Console.ReadLine();

            Console.Write("Mashinin Modelini qeyd edin:  ");
            Model = Console.ReadLine();


            Console.Write("Mashinin ProductionYear'ni qeyd edin: ");
            ProductionYear = Console.ReadLine();

            Console.Write("Mashinin Color'nu qeyd edin: ");
            Color = Console.ReadLine();

            Console.Write("Motorun olcusunu qeyd edin: ");
            MotorSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Suretler qutusunu qeyd edin: ");
            Transmission = Convert.ToInt32(Console.ReadLine());

            Console.Write("At gucunu qeyd edin: ");
            HorsePower = Convert.ToInt32(Console.ReadLine());

            Console.Write("Oturacaqlarin sayini qeyd edin: ");
            PassangerCount = Convert.ToInt32(Console.ReadLine());
        }


        public void GetDetailedInfo()
        {
            Console.Write("Yanacaq deposunun olcusunu qeyd edin: ");
            FuelTankSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("FuelAmount'u qeyd edin: ");
            FuelAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("1 kilometre serf olunan yanacaq miqdarini qeyd edin: ");
            FuelUsedPerKm = Convert.ToInt32(Console.ReadLine());
        }
    }
}