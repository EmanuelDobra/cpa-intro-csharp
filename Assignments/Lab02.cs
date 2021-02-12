using System;

/* Emanuel Dobra
   Lab 02         */

namespace Lab02
{
    class Program
    {   
        // Part 1 function
        static void isPassing(int mark) 
        {
            if (mark > 50)
            {
                Console.WriteLine("Pass");
            } else 
            {
                Console.WriteLine("Fail");
            }
        }

        // Part 2 function
        static string randomAnswer() 
        {
            string[] answerArray = {"Yes", "No", "Maybe", "Tomorrow", "Yesterday", "Never"};
            Random rnd = new Random();
            return answerArray[rnd.Next()%5+1];
        }

        static void Main(string[] args)
        {
            // Part 1
            Console.WriteLine("----------Part1----------");
            int[] gradesArray = {84,35,93,43,72};
            int gradesAmount = gradesArray.Length;
            Console.WriteLine("Enter your grade: ");
            gradesArray[4] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Array contains " + gradesAmount);
            
            for (int index = 0; index < gradesAmount; index++ )
            {
                isPassing(gradesArray[index]);
            }
            
            // Part 2
            Console.WriteLine("\n----------Part2----------");
            string answer;
            for (int questionsAsked = 0; questionsAsked < 4; questionsAsked++)
            {
                Console.WriteLine("Enter in a question you would like answered: ");
                Console.ReadLine();
                answer = randomAnswer();
                Console.WriteLine(answer);
            }
            Console.ReadLine();
        }   

    }
}
/**
Output:
----------Part1----------
Enter your grade:
52
Array contains 5
Pass
Fail
Pass
Fail
Pass

----------Part2----------
Enter in a question you would like answered:
Please say no
Maybe
Enter in a question you would like answered:
I beg you
Yesterday
Enter in a question you would like answered:
Not again...
Tomorrow
Enter in a question you would like answered:
Just a 'no' please
No

*/
