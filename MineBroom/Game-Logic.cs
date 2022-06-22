using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineBroom
{
    internal class Game_Logic
    {

        public static void Welcome()
        {
            Console.WriteLine("For aeons, people have suffered from boredom.");
            Console.WriteLine("Sitting on their computers with nothing to do.");
            Console.WriteLine("That is why, I have come from the future to deliver upon you a brand new game.");
            Console.WriteLine("Welcome to MineBroom. A completely original game with no reference to MineSweeper at all.");
            Console.WriteLine("You input a coordinate and BOOM(hopefully not boom, that could be disastrous for your health");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("How to play");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void AlreadyChosen()
        {
            Console.WriteLine("While I can appreciate the safe pick, you're not getting anywhere if you keep picking the same spot....");
            Console.WriteLine("Come on champ, give it another try. Maybe this time, don't pick the same spot.");
            Console.WriteLine("");
        }

        public static void gameOver()
        {
            Console.WriteLine("");
            Console.WriteLine("Boom!");
            Console.WriteLine("Oh nooo... your leg... I did say hopefully not boom.");
            Console.WriteLine("Well you've still got another leg, wanna give it another shot?");
        }

        public static void YouWin()
        {
            Console.WriteLine("What did I tell you, avoid the boom and you win! Since you're still here, I guess you avoided the boom so congratulations!!!");
            Console.WriteLine("");
            Console.WriteLine("You're still here? Uhhh... Wanna go again?");
        }

        public static int TryParseIndex(string strIndex, int dimensionBound)
        {
            try
            {
                // Trying to convert user input to a number
                int index = Int32.Parse(strIndex);

                if (index >= 0 && index < dimensionBound)
                {
                    return index;
                }
                else
                {
                    Console.WriteLine("I did say between 0 and 9 right?");
                    return -1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("I'm pretty sure I said between 0 and 9...");
                return -1;
            }
        }


    }
}
// Creating appropriate classes for storing such as mines and the board
// Creating methods on those classes
// Generating random mines inside of the board based on parameters of the method
// Method that will pass in a width/height and the number of mines it should make
// generate all of those appropriate mines

// If statements or loop for checking the number of mines around a given coordinate.
