using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_24_Paper_Rock_Scissor
{
    internal class Game
    {
        private (string, string) _playerSelections; //holds validated user selections
        
        //score holding variables.
        public int player1Wins = 0;
        public int player2Wins = 0;
        

        public void GameCheck()
        {
            if (_playerSelections.Item1 == "P" && _playerSelections.Item2 == "R")
            {
                Console.WriteLine("Player 1 selected paper, and Player 2 selected rock. PLAYER 1 WINS!");
                player1Wins++;
            }
            else if (_playerSelections.Item1 == "R" && _playerSelections.Item2 == "S")
            {
                Console.WriteLine("Player 1 selected rock, and Player 2 selected scissor. PLAYER 1 WINS!");
                player1Wins++;
            }
            else if (_playerSelections.Item1 == "S" && _playerSelections.Item2 == "P")
            {
                Console.WriteLine("Player 1 selected scissors, and Player 2 selected paper. PLAYER 1 WINS!");
                player1Wins++;
            }
            else if (_playerSelections.Item2 == "P" && _playerSelections.Item1 == "R")
            {
                Console.WriteLine("Player 1 selected rock, and Player 2 selected paper. PLAYER 2 WINS!");
                player2Wins++;
            }
            else if (_playerSelections.Item2 == "R" && _playerSelections.Item1 == "S")
            {
                Console.WriteLine("Player 1 selected scissors, and Player 2 selected rock. PLAYER 2 WINS!");
                player2Wins++;
            }
            else if (_playerSelections.Item2 == "S" && _playerSelections.Item1 == "P")
            {
                Console.WriteLine("Player 1 selected paper, and Player 2 selected scissors. PLAYER 1 WINS!");
                player2Wins++;
            }
            else if (_playerSelections.Item2 == _playerSelections.Item1)
            {
                Console.WriteLine("You picked the same item. This was a DRAW.");
            }
        } //Logic that determines who won the round, or if the round was a tie.

        public void CollectInputs() //Collects the user inputs and validates the inputs.
        {
            string tempUser1;
            string tempUser2;

            Console.WriteLine("Player 1, choose (P)aper, (R)ock, or (S)cissor.");
            tempUser1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Player 2, choose (P)aper, (R)ock, or (S)cissor.");
            tempUser2 = Console.ReadLine();
            Console.Clear();
            tempUser1 = tempUser1.ToUpper();
            tempUser2 = tempUser2.ToUpper();
            bool check1 = true;
            bool check2 = true;

            while (check1 == true)
            {
                if (tempUser1 != "P" && tempUser1 != "R" && tempUser1 != "S")
                {
                    Console.WriteLine("Player 1, you have provided an invalid input. Please choose (P)aper, (R)ock, or (S)cissor.");
                    tempUser1 =Console.ReadLine().ToUpper();
                    Console.Clear();
                }
                else check1 = false;
            }
            while (check2 == true)
            {
                if (tempUser2 != "P" && tempUser2 != "R" && tempUser2 != "S")
                {
                    Console.WriteLine("Player 2, you have provided an invalid input. Please choose (P)aper, (R)ock, or (S)cissor.");
                    tempUser2 = Console.ReadLine().ToUpper();
                    Console.Clear();
                }
                else check2 = false;
            }


            _playerSelections = (tempUser1, tempUser2);
        }

        public void Scoreboard()
        {
            Console.WriteLine($"Score\n_______\nPlayer 1: {player1Wins}\nPlayer 2: {player2Wins}");
            if (player1Wins > player2Wins)
            {
                Console.WriteLine("Player 1 is in the lead!");
            }
            else if (player1Wins < player2Wins)
            {
                Console.WriteLine("Player 2 is in the lead!");
            }
            else if (player1Wins == player2Wins)
            {
                Console.WriteLine("The score is currently tied!");
            }
        } //displays the current player scores and indicates who is in the lead. 

    }
}
