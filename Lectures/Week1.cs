static void Main(string[] args)
{
    // Console.ReadLine() only gets string inputs, not ints.
    Random rand = new Random();

    for (int i = 1; i < 5; i++)
    {
        //int num = rand.Next(1, 16);
        int num = rand.Next()%15+1;   
        Console.Write("Try " + i + ": " + num + "\n");
    }

    string name;
    int n;
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    Console.Write("Enter a number: ");
    n = Int32.Parse(Console.ReadLine()); //or Double.Parse() to convert to double
    Console.WriteLine("Hello " + name + ", your number was: " + n);

    Console.ReadLine(); // Stop console from closing
}        