using System;

namespace Assignment1Part1
{
    /* Bakery class, holds address and sales amount of each baked good. */
    class Bakery
    {
        public static string chainName;
        public string address;
        public int applePieSold, baguetteSold, cannolisSold;

        public Bakery(string initialAddress, int initialApplePieSold, int initialBaguetteSold, int initialCannolisSold)
        {
            address = initialAddress;
            applePieSold = initialApplePieSold;
            baguetteSold = initialBaguetteSold;
            cannolisSold = initialCannolisSold;
        }

    }
}
