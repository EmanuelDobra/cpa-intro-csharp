using System;

/* Emanuel Dobra
   Lab 01         */

namespace Lab01
{
    class Program
    {
        const double TRIP_DISTANCE= 500.0;

        static void showTripDistance()
        {
            Console.WriteLine("Trip length: " + TRIP_DISTANCE);
        }

        static int chooseCar()
        {
            int userChoice;
            Console.Write("Please enter the number that represents your vehicle," +
                " 1 = Honda Civic, 2 = Toyota Camry, 3 = Ford F - 150. Your choice: ");
            userChoice = Int32.Parse(Console.ReadLine());
            return userChoice;
        }

        static int checkCarSpeed(int carType)
        {
            switch(carType)
            {
                case 1:
                    return 10;
                case 2:
                    return 20;
                case 3:
                    return 40;
                default:
                    return 0;
            }
        }

        static double calcTripTime(int carSpeed)
        {
            return (TRIP_DISTANCE/carSpeed);
        }

        static void Main(string[] args)
        {
            int car, carSpeed;
            double tripTime = 0;
            for (int loop = 0; loop < 3; loop++)
            {
                showTripDistance();
                car = chooseCar();
                carSpeed = checkCarSpeed(car);
                tripTime = calcTripTime(carSpeed);
                Console.WriteLine("Total time taken for the trip: " + tripTime);
            }
            // Check last value of total trip time
            Console.WriteLine("Scope: " + tripTime);
            Console.ReadLine(); // Stop console from closing
        }

    }
}
/**
Output:
Trip length: 500
Please enter the number that represents your vehicle, 1 = Honda Civic, 2 = Toyota Camry, 3 = Ford F - 150. Your choice: 1
Total time taken for the trip: 50
Trip length: 500
Please enter the number that represents your vehicle, 1 = Honda Civic, 2 = Toyota Camry, 3 = Ford F - 150. Your choice: 2
Total time taken for the trip: 25
Trip length: 500
Please enter the number that represents your vehicle, 1 = Honda Civic, 2 = Toyota Camry, 3 = Ford F - 150. Your choice: 3
Total time taken for the trip: 12.5
Scope: 12.5
*/
