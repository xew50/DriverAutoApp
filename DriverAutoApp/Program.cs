using DriverAutoLibrary;
using System;

namespace DriverAutoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver
            {
                Name = "Григорьев Илья Игоревич",
                Class = "A"
            };

            driver.Autos.Add(new Auto { Title = "Toyota", Number = "A123BC" });
            driver.Autos.Add(new Auto { Title = "Honda", Number = "B456CD" });
            driver.Autos.Add(new Auto { Title = "Ford", Number = "C789EF" }); //Григорьев(Родькин) 34ИС

            driver.Show();
            driver.ShowAll();


            Console.ReadKey();
        }
    }
}