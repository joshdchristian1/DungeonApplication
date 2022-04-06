using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace Dungeon
{
    internal class DungeonGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dungeon!\n");
            Console.Title = "Dungeon Game";

            //TODO Create Character

            Character c1 = new Character(100, "Rylan", 85, 22, 60, 10);
            Console.WriteLine(c1);
            
            
            

            bool exit = false;
        
            do
            {
                Console.WriteLine(Room());

                //TODO Create Monster


                bool reload = false;

                do
                {
                    Console.WriteLine("\nPlease select one of the following options");
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
                        case "e":
                        case "escape":
                            Console.WriteLine("Thank you for playing the Dungeon Game\n\n");

                            exit = true;

                            break;//break the fall!


                        default:
                            Console.WriteLine("That was not a valid option.\n");
                            break;
                    }//end switch
                } while (!exit && !reload); 

            } while (!exit);

        
        }//end main()

        private static string Room()
        {

            string[] rooms =
            {
                "Your room is perched high on a cliffside with the wind swirling around you.",
                "The room is nearly pitch black, you hear sounds but can barely see your hand in front of your face.",
                "The room is watery and dank, it must be where all the waste comes to rest.",
                "The room has the acrid smell of sulfur, it is unbearable hot.",
                "The room is white with frost, you feel a spine tingling sensation creep up your back",


            };


            Random randomRoom = new Random();

            int indexNbr = randomRoom.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }//end Room()

    }//end class
}//end namespace
