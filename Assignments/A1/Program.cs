using System;

namespace Assignment1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 2
            Bakery firstBakery = new Bakery("4262563", 25, 46, 32);
            Bakery secondBakery = new Bakery("1st avenue", 54, 23, 12);

            // step 3
            Console.WriteLine("Re-enter the amount of apple pies sold at the first bakery: ");
            firstBakery.applePieSold = Int32.Parse(Console.ReadLine());

            // step 6
            Console.WriteLine(Bakery.chainName);
            Console.WriteLine(firstBakery._address);
            Console.WriteLine("-----> " + "Apple Pies: " + firstBakery.applePieSold);
            Console.WriteLine("-----> " + "Baguettes: " + firstBakery.baguetteSold);
            Console.WriteLine("-----> " + "Cannolis: " + firstBakery.cannolisSold);

            Console.WriteLine(secondBakery._address);
            Console.WriteLine("-----> " + "Apple Pies: " + secondBakery.applePieSold);
            Console.WriteLine("-----> " + "Baguettes: " + secondBakery.baguetteSold);
            Console.WriteLine("-----> " + "Cannolis: " + secondBakery.cannolisSold);

            // step 7 
            if (firstBakery.GetTotalSold() > secondBakery.GetTotalSold()) {
                Console.WriteLine("Bakery at the address " + firstBakery._address + " sold the most goods: " + firstBakery.GetTotalSold());
            } else if (secondBakery.GetTotalSold() > firstBakery.GetTotalSold()) {
                Console.WriteLine("Bakery at the address " + secondBakery._address + " sold the most goods: " + secondBakery.GetTotalSold());
            } else {
                Console.WriteLine("Both bakeries sold the same ammount of goods of " + firstBakery.GetTotalSold());
            }
            
            


            Bakery myBakery = new Bakery("1st avenue", 5, 8, 11);
            Bakery.chainName = "Cahoo Chain";
            Console.WriteLine("Chain: " + Bakery.chainName);
            Console.WriteLine("The bakery's address is " + myBakery._address);
            Console.WriteLine("Goods sold: " + "\nApple Pies: " + myBakery.applePieSold
                + "\nBaguettes: " + myBakery.baguetteSold + "\nCannolis: " + myBakery.cannolisSold);
            Console.ReadLine();
        }
    }
}
