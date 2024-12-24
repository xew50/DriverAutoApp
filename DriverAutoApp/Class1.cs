using System;
using System.Collections.Generic;

namespace DriverAutoLibrary
{
    public class Auto
    {
        public string Title { get; set; }
        public string Number { get; set; }

        public void Show()
        {
            Console.WriteLine($"Автомобиль: {Title}, Госномер: {Number}");
        }
    }

    public class Driver
    {
        public string Name { get; set; }
        public string Class { get; set; } //Григорьев(Родькин) 34 ИС
        public List<Auto> Autos { get; set; } = new List<Auto>();

        public void Show()
        {
            Console.WriteLine($"Водитель: {Name}, Квалификация: {Class}");
        }

        public void ShowAll()
        {
            foreach (var auto in Autos)
            {
                auto.Show();
            }
        }
    }
}
