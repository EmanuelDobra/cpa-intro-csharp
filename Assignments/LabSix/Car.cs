using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    // Name: Emanuel Dobra
    class Car
    {
        public string name;
        public double price;
        public int odometer;
        public static double deprecRate;
        
        public Car(string initialName, double initialPrice, int initialOdometer)
        {
            name = initialName;
            price = initialPrice;
            odometer = initialOdometer;
        }

        public double DetermineValue()
        {
            return price * (1-deprecRate);
        }
    }
}
