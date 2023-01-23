/*1) The “Driver” class (the class with the main method where the program starts) will:
• Welcome the user to the game
• Create a game board array to store the players’ choices
• Ask each player in turn for their choice and update the game board array
• Print the board by calling the method in the supporting class
• Check for a winner by calling the method in the supporting class, and notify the players
when a win has occurred and which player won the game */

using System;

namespace Driver
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Initialize array and positions 
            string[] arrBoard = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            int Player1Position = 0;
            int Player2Position = 0;
            string strResults = null;
            int i = 0;

            Console.WriteLine("Welcome to the game, playa!");
            Support st = new Support();
            st.PrintBoard(arrBoard);

            //Loop through the game until there is a winner
            while (strResults == null)
            {

                Console.WriteLine("\n" + "Player 1, enter a number (0-8) for where you want to place your X: ");
                Player1Position = int.Parse(Console.ReadLine());

                //Check to see if the position has already been taken
                if (arrBoard[Player1Position] == Convert.ToString(Player1Position))
                {
                    arrBoard[Player1Position] = Char.ToString('O');
                }
                else
                {
                    //If the position is already taken, loop through until a valid position is chosen
                    while (arrBoard[Player1Position] != Convert.ToString(Player1Position))
                    {
                        Console.WriteLine("That spot is already taken. Please enter a valid position: ");
                        Player1Position = int.Parse(Console.ReadLine());
                    }

                    arrBoard[Player1Position] = Char.ToString('O');
                }
                i++;
                //Check to see if there is a winner and display the Board
                strResults = st.ReceiveBoard(arrBoard);
                st.PrintBoard(arrBoard);

                //Break out of the loop if there is a winner
                if (strResults != null)
                {
                    break;
                }

                //Manually force a tie if 9 turns have been taken
                if (i == 9)
                {
                    break;
                }

                Console.WriteLine("\nPlayer 2, enter a number (0-8) for where you want to place your O: ");
                Player2Position = int.Parse(Console.ReadLine());

                //Check to see if the position has already been taken
                if (arrBoard[Player2Position] == Convert.ToString(Player2Position))
                {
                    arrBoard[Player2Position] = Char.ToString('O');
                }
                else
                {
                    //If the position is already taken, loop through until a valid position is chosen
                    while (arrBoard[Player2Position] != Convert.ToString(Player2Position))
                    {
                        Console.WriteLine("That spot is already taken. Please enter a valid position: ");
                        Player2Position = int.Parse(Console.ReadLine());
                    }

                    arrBoard[Player2Position] = Char.ToString('O');
                }


                //Check to see if there is a winner and display the Board
                strResults = st.ReceiveBoard(arrBoard);
                st.PrintBoard(arrBoard);
                i++;
            }


            //Declare a winner
            if (strResults == "Player1")
            {
                Console.WriteLine("Player1 has won the game!");
            }
            else if (strResults == "Player2")
            {
                Console.WriteLine("Player2 has won the game!");
            }
            else
            {
                Console.WriteLine("The game has ended in a tie!");
            }
        }
    }
}
