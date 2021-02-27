using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    // Name: Emanuel Dobra
    class Program
    {
        static void Main(string[] args)
        {
            Car.deprecRate = 0.15;
            Car toyota = new Car("Toyota", 4000.99, 54350);
            Car chovrelet = new Car("Chovrelet", 6500.50, 83235);

            toyota.odometer = 98000;
            Console.WriteLine("Car: " + toyota.name + ", odometer: " + toyota.odometer);

            Console.WriteLine("Car: " + toyota.name + ", depreciated total value: " + toyota.DetermineValue());
            Console.WriteLine("Car: " + chovrelet.name + ", depreciated total value: " + chovrelet.DetermineValue());
            Console.ReadLine();
        }
    }
}
