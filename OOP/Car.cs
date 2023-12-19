using System;
using System.Collections.Generic;
using static ConsoleHelper_50.Helper_50;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m7_2
{
    class Car
    {
        public decimal FuelAmount;
        public int Mileage;
        public string Name;

        /// <summary>
        /// Метод, указывающий на исчерпание топлива
        /// Подразумевалось, что этот метод будет вызываться для классических автомобилей текущего класса
        /// (аналогично со строковой переменной noFuel)
        /// </summary>
        public virtual void NoFuel()
        {
            Console.WriteLine("base METHOD. Not enough fuel, engine stopped");
        }
        private const string noFuel = "VAR. Not enough fuel, engine stopped";

        public Car(string name, decimal fuel)
        {
            FuelAmount = fuel;
            Mileage = 0;
            this.Name = name;
        }
        public Car(string name) : this(name, 1M) { }

        /// <summary>
        /// Базовый метод Move, движение на 1 единицу расстояния
        /// </summary>
        /// <returns></returns>
        public virtual bool Move()
        {
            //Console.WriteLine("Для объекта {0} вызван метод Move класса Car", Name);
            if (FuelAmount > 0.00M)
            {
                Mileage++;
                FuelAmount -= 0.10M;
                TripInfo();
                return true;
            } else
            {
                NoFuel();
                //Console.WriteLine(noFuel);
                return false;
            }
        }

        /// <summary>
        /// Выводит инфо о поездке
        /// </summary>
        public virtual void TripInfo()
        {
            Console.WriteLine("<< current FuelAmount = {0:0.00}, current Mileage = {1} >>", FuelAmount, Mileage);
        }

        /// <summary>
        /// Выводит общий пробег и остаток топлива
        /// </summary>
        public virtual void Summary()
        {
            Console.WriteLine("TOTAL FUEL AMOUNT = {0:0.00}, TOTAL MILEAGE = {1}", FuelAmount, Mileage);
        }
    }
    enum FuelTypes
    {
        Gas = 0,
        Electricity
    }
    class HybridCar : Car
    {
        public FuelTypes FuelType { get; private set; }
        public Dictionary<FuelTypes, decimal> InternalFuelAmount;

        /// <summary>
        /// Метод, указывающий на исчерпание топлива
        /// Подразумевалось, что данный метод переопределен в производном классе, и будет вызываться для гибридных автомобилей
        /// </summary>
        private new void NoFuel()
        {
            Console.WriteLine("new METHOD. The current fuel is exhausted. Please, change fuel type to continue driving");
        }
        private const string noFuel = "VAR. The current fuel is exhausted. Please, change fuel type to continue driving";

        public HybridCar(string name, FuelTypes startFuelType) : base(name)
        {
            InternalFuelAmount = new()
            {
                { FuelTypes.Gas, 1M },
                { FuelTypes.Electricity, 1M },
            };
            ChangeFuelType(startFuelType);
        }
        public HybridCar(string name) : this(name, FuelTypes.Electricity) { }

        /// <summary>
        /// Метод смены типа топлива
        /// </summary>
        /// <param name="type"></param>
        public void ChangeFuelType(FuelTypes type)
        {
            FuelType = type;
            FuelAmount = InternalFuelAmount[type];
            Console.WriteLine("Current fuel type is {0}", FuelType);
        }

        /// <summary>
        /// Переопределенный метод Move, движение на 1 единицу расстояния
        /// В начале работы вызывает метод базового класса
        /// </summary>
        /// <returns></returns>
        public override bool Move()
        {
            bool result = base.Move();
            if (result)
            {
                //Console.WriteLine("Для объекта {0} вызван метод Move класса HybridCar", Name);
                InternalFuelAmount[FuelType] = FuelAmount;
                return result;
            } else
            {
                NoFuel();
                //Console.WriteLine(noFuel);
                return result;
            }    
        }

        /// <summary>
        /// Выводит инфо о поездке (переопределен)
        /// </summary>
        public override void TripInfo()
        {
            Console.WriteLine("<< Fuel left: gas = {0}, electricity = {1} >>", InternalFuelAmount[FuelTypes.Gas], InternalFuelAmount[FuelTypes.Electricity]);
        }

        /// <summary>
        /// Выводит общий пробег и остаток топлива (переопределен)
        /// </summary>
        public override void Summary()
        {
            string anotherType = "undefined";
            decimal anotherAmount = -1M;
            foreach (var field in InternalFuelAmount)
            {
                if (field.Key != FuelType)
                {
                    anotherType = field.Key.ToString();
                    anotherAmount = field.Value;
                }
            }
            Console.WriteLine("Current fuel is {0}, available balance is = {1:0.00}, ", FuelType, FuelAmount);
            Console.WriteLine("Another fuel ({0}) is available {1:0.00}. TOTAL MILEAGE = {2}", anotherType, anotherAmount, Mileage);
        }
    }
}
