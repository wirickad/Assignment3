using System;

namespace Mission3group2_11
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Initialize array and positions 
            string[] arrBoard = {"0","1", "2", "3", "4", "5", "6", "7", "8"};
            int Player1Position = 0;
            int Player2Position = 0;
            string strResults = null;

            Console.WriteLine("Welcome to the game, playa!");
            //Support.PrintBoard(arrBoard);

            //Loop through the game until there is a winner
            while (strResults == null)
            {
                
                Console.WriteLine("\n" + "Player 1, enter a number (0-8) for where you want to place your X: ");
                Player1Position = int.Parse(Console.ReadLine());

                //Check for a valid entry
                while (0 > Player1Position && Player1Position > 8)
                {
                    Console.WriteLine("\n" + "Invalid Entry. Please try again: ");
                    Player1Position = int.Parse(Console.ReadLine());
                }
                
                //Check to see if the position has already been taken
                if (arrBoard[Player1Position] == Convert.ToString(Player1Position))
                {
                    arrBoard[Player1Position] = Char.ToString('X');
                }
                else
                {
                    //If the position is already taken, loop through until a valid position is chosen
                    while (arrBoard[Player1Position] != Convert.ToString(Player1Position))
                    {
                        Console.WriteLine("That spot is already taken. Please enter a valid position: ");
                        Player1Position = int.Parse(Console.ReadLine());
                    }

                    arrBoard[Player1Position] = Char.ToString('X');
                }

                //Check to see if there is a winner and display the Board
                //strResults = Support.ReceiveBoard(arrBoard);
                //Support.PrintBoard(arrBoard);

                //Break out of the loop if there is a winner
                if (strResults != null)
                {
                    break;
                }

                Console.WriteLine("\nPlayer 2, enter a number (0-8) for where you want to place your O: ");
                Player2Position = int.Parse(Console.ReadLine());
                
                //Check for a valid entry
                while (0 > Player2Position && Player2Position > 8)
                {
                    Console.WriteLine("\n" + "Invalid Entry. Please try again: ");
                    Player2Position = int.Parse(Console.ReadLine());
                }
                
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
                //strResults = Support.ReceiveBoard(arrBoard);
                //Support.PrintBoard(arrBoard);
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
