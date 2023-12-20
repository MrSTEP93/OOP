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
            //MoveHybridCar();

            //BooksAction();

            Employee employee = new Employee("Николай", new DateTime(1988, 12, 23), true);
            Guest guest = new Guest("Андрей", new DateTime(1993, 01, 05), new DateTime(2020, 11, 05));

        }

        private static void MoveClassicCar()
        {
            GasCar myCar = new("Vesta SW Red");
            for (int i = 0; i < 7; i++)
            {
                myCar.Move();
            }
            myCar.TotalInfo();

            for (int i = 0; i < 5; i++)
            {
                myCar.Move();
            }
            myCar.TotalInfo();
        }

        private static void MoveHybridCar()
        {
            var newCar = new HybridCar("Range PHEV");
            for (int i = 0; i < 7; i++)
            {
                newCar.Move();
            }
            newCar.TotalInfo();
            Console.WriteLine();
            newCar.ChangeFuelType(FuelTypes.Gas);

            for (int i = 0; i < 5; i++)
            {
                newCar.Move();
            }
            newCar.TotalInfo();
        }

        static void BooksAction()
        {
            var array = new Book[]
            {
                new Book
                {
                  Name = "Мастер и Маргарита",
                  Author = "М.А. Булгаков"
                },
                new Book
                {
                  Name = "Отцы и эти",
                  Author = "И.С. Тургенев"
                },
            };
            BookCollection collection = new BookCollection(array);

            Book book1 = collection[1];
            Console.WriteLine("Книга \"{0}\" от автора {1}", book1.Name, book1.Author);
            
            Book book2 = collection["маргарита"];
            Console.WriteLine("Книга \"{0}\" от автора {1}", book2.Name, book2.Author);
        }
    }
}
