using System;

/* Emanuel Dobra
   Assignment 1 - Phase 1 */

namespace A1Phase1
{
    // GET AND SET
    /*
    private string name; 
    public void setName(string assignName) {
        name = assignName; 
    }
    public string getName() {
        return name;
    }*/
    /* Bakery class, holds address and sales amount of each baked good. */
    class Bakery
    {
        static string chainName = "Las Diravas";
        public string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int _breadSold, _bread2Sold, _bread3Sold;
        public int breadSold
        {
            get { return _breadSold; }
            set { _breadSold = value; }
        }

        public int bread2Sold
        {
            get { return _bread2Sold; }
            set { _bread2Sold = value; }
        }

        public int bread3Sold
        {
            get { return _bread3Sold; }
            set { _bread3Sold = value; }
        }

        public Bakery(string bakeryAddress, int firstGood, int secondGood, int thirdGood)
        {
            address = bakeryAddress;
            breadSold = firstGood;
            bread2Sold = secondGood;
            bread3Sold = thirdGood;
        }
        static void Main(string[] args)
        {
            Bakery bakery1 = new Bakery("1st avenue", 5, 8, 11);
            //bakery1.chainName = "Chain 1";
            //Console.WriteLine("Chain: " + bakery1.chainName);
            Console.WriteLine("The bakery's address is " + bakery1.address);
            Console.WriteLine("Goods sold: " + "\nGood 1: " + bakery1.breadSold
                + "\nGood 2: " + bakery1.bread2Sold + "\nGood 3: " + bakery1.bread3Sold);
            Console.ReadLine();
        }
    }
}

