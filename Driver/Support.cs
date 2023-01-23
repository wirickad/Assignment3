using System;
using System.Collections.Generic;
using System.Text;
/*2) The supporting class will:
• Receive the “board” array from the driver class
• Contain a method that prints the board based on the information passed in
• Contain a method that receives the game board array as input and returns if there is a
winner and who it was*/

namespace Driver
{
    public class Support
    {
        public void PrintBoard(string[] Board)
        {
            Console.WriteLine("    {0}  |   {1}   |   {2}", Board[0], Board[1], Board[2]);
            Console.WriteLine("--------------------");
            Console.WriteLine("    {0}  |   {1}   |   {2}", Board[3], Board[4], Board[5]);
            Console.WriteLine("--------------------");
            Console.WriteLine("    {0}  |   {1}   |   {2}", Board[6], Board[7], Board[8]);

        }
        public string ReceiveBoard(string[] Board)
        {
            
            string winner = "";
            
            
           
               if (Board[0] == Board[3] && Board[3] == Board[6])
                    {
                        winner = Board[0];
                    }
               else if (Board[0] == Board[1] && Board[1] == Board[2])
                    {
                        winner = Board[0];
                    }
               else if (Board[0] == Board[4] && Board[4] == Board[8]) 
                    {
                        winner = Board[0];
                    }
               else if (Board[3] == Board[4] && Board[4] == Board[5])
                    {
                        winner = Board[3];
                    }
               else if (Board[6] == Board[7] && Board[7] == Board[8])
                    {
                        winner  = Board[6];
                    }
               else if (Board[1] == Board[4] && Board[4] == Board[7])
                    {
                        winner  = Board[1];
                    }
               else if (Board[2] == Board[4] && Board[4] == Board[6])
                    {
                         winner  = Board[2];
                    }
               else if (Board[2] == Board[5] && Board[5] == Board[8])
                    {
                         winner  = Board[2];
                    }
               else
                    {
                        winner = null;
                    }
            if (winner == "X")
            {
                winner = "Player 1";
            }
            else if (winner == "O")
            {
                winner = "Player 2";
            }
            else
            {
                winner = null;
            }
            //for (int i = 0; i < Board.Length; i++)
            //{
            //    if (Board[i] != "X" || Board[i] != "O")
            //    {
            //        Console.Write("kjlkj");
            //        winner = "Draw";
            //        return winner;
            //    }
            //}

            return winner;
                
        }
    }
}
