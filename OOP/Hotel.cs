using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m7_2
{
    abstract class Person
    {
        public string Name;
        public byte Age;
        private DateTime Birthdate;

        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
            Age = Convert.ToByte(DateTime.Now.Year - Birthdate.Year);
            if (birthdate.Date > DateTime.Now.AddYears(-Age)) 
                Age--;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        // Булевый флаг, сообщающий, находится ли сотрудник на смене
        public bool IsOnShift;

        public Employee(string name, DateTime birthDate, bool isOnShift) : base(name, birthDate)
        {
            IsOnShift = isOnShift;
        }
    }
    class Guest : Person
    {
        // Дата и время прибытия гостя
        public DateTime ArrivalDate;

        public Guest(string name, DateTime birthDate, DateTime arrivalDate) : base(name, birthDate)
        {
            ArrivalDate = arrivalDate;
        }
    }
}
