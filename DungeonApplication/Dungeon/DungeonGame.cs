using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class DungeonGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dungeon!");
            Console.Title = "Dungeon Game";


            //TODO Create Character
            bool exitGame = false;
            do
            {
                //TODO Create Monster
                //TODO Create A Room
                bool exit = false;

                do
                {
                    Console.WriteLine("Please select one of the following options");
                    Console.WriteLine("A) Attack\nR) Run away\nC) Character Information\nM) Monster Information\nX) Exit");
                    string userChoice = Console.ReadKey(true).Key.ToString().ToLower();
                    Console.Clear();


                    switch (userChoice)
                    {

                        case "a":
                            Console.WriteLine("Attack\n");
                            break;//break the fall!



                        //if withdraw, ask them for the amount to withdraw, and display the amount being withdrawn
                        case "r":
                            Console.WriteLine("Run away\n");

                            break;//break the fall!


                        case "c":
                            Console.WriteLine("Character Information\n");
                            break;//break the fall!

                        case "m":
                            Console.WriteLine("Monster Information\n");
                            break;//break the fall!


                        case "x":
                        case "escape":
                            Console.WriteLine("Thank you for playing the Dungeon Game\n\n");
                            exit = true;
                            exitGame = true;
                            break;//break the fall!


                        default:
                            Console.WriteLine("That was not a valid option.\n");
                            break;
                    }//end switch
                } while (!exit);

            } while (!exitGame);
        }
    }
}
