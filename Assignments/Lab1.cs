using System;

/* Emanuel Dobra
   Lab 1         */

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1, guessing game
            Random rand = new Random();
            int guess, answer;

            do {
                answer = rand.Next() % 10 + 1;
                Console.Write("I'm thinking of a number between 1 and 10, try guessing it: ");
                guess = Int32.Parse(Console.ReadLine());
                if (guess != answer)
                {
                    Console.WriteLine("Wrong! The number was " + answer + "!");
                } else
                {
                    Console.WriteLine("Correct! You are now freed from this loop.");
                }
            } while (guess != answer);

            // Part 2, select course
            bool isCourse = false;
            string course;
            Console.Write("What course are you in now: ");
            course = Console.ReadLine();
            switch (course)
            {
                case "COMP60":
                    Console.WriteLine("Learning C#");
                    isCourse = true;
                    break;
                case "COMP1100":
                    Console.WriteLine("Learning C++");
                    break;
                default:
                    Console.WriteLine("Not a CPA course");
                    break;
            }

            if(isCourse)
            {
                Console.WriteLine("You are in the right course!");
            } else 
            {
                Console.WriteLine("You are in the wrong course :(");
            }


            Console.ReadLine(); // Stop console from closing
        }
    }
}
/**
Output:
I'm thinking of a number between 1 and 10, try guessing it: 5
Wrong! The number was 9!
I'm thinking of a number between 1 and 10, try guessing it: 5
Wrong! The number was 6!
I'm thinking of a number between 1 and 10, try guessing it: 5
Wrong! The number was 1!
I'm thinking of a number between 1 and 10, try guessing it: 5
Wrong! The number was 4!
I'm thinking of a number between 1 and 10, try guessing it: 5
Correct! You are now freed from this loop.
What course are you in now: COMP60
Learning C#
You are in the right course!

*/
