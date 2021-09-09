using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Emanuel Dobra

namespace Assignment2Phase1
{
    class Game
    {
        public static string[] targetWords = {"crematorium", "landowner", "faraway", "cookie", "southern"};
        public static int[] prizeAmoutns = {200, 500, 750, 1000, 5000};
        public string targetWord;
        public Random randomGen;
        
        public Game()
        {
            randomGen = new Random();
            assignTarget();
        }

        public void assignTarget()
        {
            targetWord = targetWords[randomGen.Next(targetWords.Length)];
        }
    }
}