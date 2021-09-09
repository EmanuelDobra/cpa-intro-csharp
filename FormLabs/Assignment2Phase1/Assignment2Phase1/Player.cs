using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Emanuel Dobra

namespace Assignment2Phase1
{
    class Player
    {
        public string playerName;
        public int playerScore;
        public int winsTotal;
        public int lossesTotal;

        public Player(string initialPlayerName)
        {
            playerName = initialPlayerName;
            playerScore = 0;
            winsTotal = 0;
            lossesTotal = 0;
        }
    }
}