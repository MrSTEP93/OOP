using Microsoft.VisualBasic.FileIO;
using System;

namespace m7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //MoveClassicCar();
            MoveHybridCar();

        }

        private static void MoveClassicCar()
        {
            Car myCar = new("Vesta SW Red");
            for (int i = 0; i < 7; i++)
            {
                myCar.Move();
            }
            myCar.Summary();

            for (int i = 0; i < 5; i++)
            {
                myCar.Move();
            }
            myCar.Summary();
        }

        private static void MoveHybridCar()
        {
            var newCar = new HybridCar("Range PHEV");
            for (int i = 0; i < 7; i++)
            {
                newCar.Move();
            }
            newCar.Summary();
            Console.WriteLine();
            newCar.ChangeFuelType(FuelTypes.Gas);

            for (int i = 0; i < 5; i++)
            {
                newCar.Move();
            }
            newCar.Summary();
        }

        private static void CheckIndexator()
        {
            Car[] cars = new Car[10];

            cars[0] = new Car("Vesta SW Red");
            //cars[1] = new HybridCar("Prius");
            //cars[2] = new Car("Vesta SW White");

        }
    }
}
