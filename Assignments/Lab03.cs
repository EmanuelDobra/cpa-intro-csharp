using System;

/* Emanuel Dobra
   Lab 03         */

namespace Lab02
{
    class Student
    {
        public string name;
        public int section;
        public double[] currentGrades = new double[4];
    }
    class Program
    {
        static void printHellloString(string sentence)
        {
            Console.WriteLine("Hello " + sentence);
        }

        static void Main(string[] args)
        {
            Student studentOne = new Student();
            Student studentTwo = new Student();
            studentOne.name = "Emanuel Dobra";
            studentTwo.name = "Tar Gonzales";
            studentOne.section = 100;
            studentTwo.section = 200;
            double[] st1Grades = { 53.54, 73.54, 62.27, 92.40 };
            double[] st2Grades = { 73.34, 53.00, 42.47, 96.26 }; 
            // below assignments work to
            //studentOne.currentGrades = st1Grades;
            //studentTwo.currentGrades = st2Grades; 

            // Populate objects' arrays
            for (int gradesIndex = 0; gradesIndex < 4; gradesIndex++)
            {
                studentOne.currentGrades[gradesIndex] = st1Grades[gradesIndex];
                studentTwo.currentGrades[gradesIndex] = st2Grades[gradesIndex];
            }

            Console.WriteLine("Student One: " + studentOne.name 
                + " is in section " + studentOne.section);
            Console.WriteLine("Student Two: " + studentTwo.name 
                + " is in section " + studentTwo.section);
            
            studentTwo.name = "Bob";
            printHellloString(studentTwo.name);

            studentOne.currentGrades[2] = 67.5;
            for (int gradesIndex = 0; gradesIndex < studentOne.currentGrades.Length; gradesIndex++)
            {
                Console.Write("Grade " + (gradesIndex + 1) + ": " 
                    + studentOne.currentGrades[gradesIndex]);
                // Organizing output
                if (gradesIndex < 3)
                {
                    Console.Write(", ");
                } else
                {
                    Console.Write("\n");
                }
            }
            printHellloString(studentOne.name);
            Console.ReadLine();
        }

    }
}
/**
Output:
Student One: Emanuel Dobra is in section 100
Student Two: Tar Gonzales is in section 200
Hello Bob
Grade 1: 53.54, Grade 2: 73.54, Grade 3: 67.5, Grade 4: 92.4
Hello Emanuel Dobra
*/
