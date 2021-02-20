using System;

namespace Assignment1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery myBakery = new Bakery("1st avenue", 5, 8, 11);
            Bakery.chainName = "Cahoo Chain";
            Console.WriteLine("Chain: " + Bakery.chainName);
            Console.WriteLine("The bakery's address is " + myBakery.address);
            Console.WriteLine("Goods sold: " + "\nApple Pies: " + myBakery.applePieSold
                + "\nBaguettes: " + myBakery.baguetteSold + "\nCannolis: " + myBakery.cannolisSold);
            Console.ReadLine();
        }
    }
}
