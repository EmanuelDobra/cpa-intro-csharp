using System;

namespace Assignment1Part1
{
    /* Bakery class, holds address and sales amount of each baked good. */
    class Bakery
    {
        public static string chainName = "Emanuel's Baked Goods";
        private string address;
        public string _address
        {
            get { return address; }
            set { address = value; }
        }
        public int applePieSold, baguetteSold, cannolisSold;

        public Bakery(string initialAddress, int initialApplePieSold, int initialBaguetteSold, int initialCannolisSold)
        {
            _address = initialAddress;
            applePieSold = initialApplePieSold;
            baguetteSold = initialBaguetteSold;
            cannolisSold = initialCannolisSold;
        }

        public int GetTotalSold()
        {
            return (applePieSold + baguetteSold + cannolisSold);
        }
    }
}
