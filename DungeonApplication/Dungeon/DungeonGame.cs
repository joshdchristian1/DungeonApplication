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


            bool exitGame = false;
        characterSelectMenu:;
            do
            {
                Console.WriteLine("Please choose your Warrior");
                Console.WriteLine("A) Rylan\nB) McKenna\nC) Rachel\nD) Josh\nX) Exit");
                string userCharacter = Console.ReadKey(true).Key.ToString().ToLower();
                Console.Clear();


                switch (userCharacter)
                {

                    case "a":
                        Console.WriteLine("You chose Rylan\n");
                        break;//break the fall!



                    //if withdraw, ask them for the amount to withdraw, and display the amount being withdrawn
                    case "b":
                        Console.WriteLine("You chose McKenna\n");

                        break;//break the fall!


                    case "c":
                        Console.WriteLine("You chose Rachel\n");
                        break;//break the fall!

                    case "d":
                        Console.WriteLine("You chose Josh\n");
                        break;//break the fall!


                    case "x":
                    case "escape":
                        Console.WriteLine("Thank you for playing the Dungeon Game\n\n");
                           
                        goto endOfProgram;
                        break;//break the fall!


                    default:
                        Console.WriteLine("That was not a valid option.\n");
                        goto characterSelectMenu;
                        break;
                }//end switch
                //TODO Create Character

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
                            //TODO Attack
                            break;//break the fall!



                        //if withdraw, ask them for the amount to withdraw, and display the amount being withdrawn
                        case "r":
                            Console.WriteLine("Run away\n");
                            //TODO Run away
                            break;//break the fall!


                        case "c":
                            Console.WriteLine("Character Information\n");
                            break;//break the fall!
                            //TODO Character Information

                        case "m":
                            Console.WriteLine("Monster Information\n");
                            //TODO Monster Information
                            break;//break the fall!


                        case "x":
                        case "escape":
                            Console.WriteLine("Thank you for playing the Dungeon Game\n\n");

                            exit = true;

                            break;//break the fall!


                        default:
                            Console.WriteLine("That was not a valid option.\n");
                            break;
                    }//end switch
                } while (!exit);

            } while (!exitGame);

        endOfProgram:;
        }
    }
}
