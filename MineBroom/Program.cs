using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineBroom
{
    class Program
    {

        static void Main(string[] args)
        {
            Grid playingGrid = new Grid(10, 10); // Creating Playing Grid 
            playingGrid.BombCreator(10); // Creates bombs
            Game_Logic.Welcome(); // Welcome to the game :)     

            int guessCounter = 0; // Guess counter

            // Allowing User to Make Guesses
            bool gameActive = true;

            while (gameActive == true)
            {
                int userCol = -1;
                int userRow = -1;

                while (userCol == -1)
                {
                    Console.WriteLine($"Enter column number between {0} and {playingGrid.GridWidth - 1}");
                    string col = Console.ReadLine();
                    Console.WriteLine("");
                    int result = Game_Logic.TryParseIndex(col, playingGrid.GridWidth);
                    if (result != -1)
                    {
                        userCol = result;
                    }
                }

                while (userRow == -1)
                {
                    Console.WriteLine($"Enter row number between {0} and {playingGrid.GridHeight - 1}");
                    string row = Console.ReadLine();
                    Console.WriteLine("");
                    int result = Game_Logic.TryParseIndex(row, playingGrid.GridHeight);

                    if (result != -1)
                    {
                        userRow = result;
                    }

                }

                Console.WriteLine($"Cell chosen: [{userCol},{userRow}]"); // Displaying cell chosen by user                
                Cell userGuess = playingGrid.GameGrid[userCol, userRow]; //Storing User's Guess


                if (userGuess.isBomb == false && userGuess.alreadyChecked == true)
                {
                    Game_Logic.AlreadyChosen();
                }

                if (userGuess.isBomb == false && userGuess.alreadyChecked == false)
                {
                    guessCounter++;
                    userGuess.alreadyChecked = true;
                    Console.WriteLine($"Nice! {guessCounter} down {playingGrid.GridWidth * playingGrid.GridHeight - (10 + guessCounter)} bottles of bee... I mean mines left!!");
                    Console.WriteLine("");
                }

                playingGrid.BombChecker(userCol, userRow); // Checking for bombs                
                Console.WriteLine(playingGrid.BombChecker(userCol, userRow)); // Displaying number of bombs
                Console.WriteLine("");

            
                if (guessCounter == playingGrid.GridWidth * playingGrid.GridHeight - 10)
                {
                    Game_Logic.YouWin();
                    gameActive = false;
                }


                if (userGuess.isBomb == true)
                {
                    Game_Logic.gameOver();
                    gameActive = false;
                }

            }
        }

    }}


// See https://aka.ms/new-console-template for more information
// Creating appropriate classes for storing such as mines and the board
// Creating methods on those classes
// Generating random mines inside of the board based on parameters of the method
// Method that will pass in a width/height and the number of mines it should make
// generate all of those appropriate mines

// If statements or loop for checking the number of mines around a given coordinate.