using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace Dungeon
{
    class DungeonGame
    {
        static void Main(string[] args)
        {
        mainMenu:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcome to the Dungeon, It gets worse here everyday!\n");
            Console.Title = "Dungeon Game";
            Console.ForegroundColor = ConsoleColor.White;

            int score = 0;

            #region Weapons


            //Weapons
            //Type, Name, Min Damage, Max Damage, Bonus Hit Chance, Two Handed
            Weapon claymore = new Weapon(WeaponType.Sword, "Claymore", 3, 12, 10, true);
            Weapon rapier = new Weapon(WeaponType.Sword, "Rapier", 1, 8, 20, false);
            Weapon battleAxe = new Weapon(WeaponType.Axe, "Battle Axe", 5, 20, 0, true);
            Weapon vikingAxe = new Weapon(WeaponType.Axe, "Viking Axe", 1, 6, 30, false);
            Weapon stiletto = new Weapon(WeaponType.Dagger, "Stiletto", 1, 4, 40, false);
            Weapon dirk = new Weapon(WeaponType.Dagger, "Dirk", 1, 5, 35, false);
            Weapon fireStaff = new Weapon(WeaponType.Staff, "Fire Staff", 1, 10, 20, false);
            Weapon frostStaff = new Weapon(WeaponType.Staff, "Frost Staff", 3, 15, 0, false);
            Weapon longBow = new Weapon(WeaponType.Bow, "Long Bow", 1, 6, 13, true);
            Weapon recurvedBow = new Weapon(WeaponType.Bow, "Recurved Bow", 1, 9, 9, true);
            Weapon blackPowderRifle = new Weapon(WeaponType.Rifle, "Black Powder Rife", 5, 12, 5, true);
            Weapon laserRifle = new Weapon(WeaponType.Rifle, "Laser Rife", 3, 10, 15, true);

            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(claymore);
            weapons.Add(rapier);
            weapons.Add(battleAxe);
            weapons.Add(vikingAxe);
            weapons.Add(stiletto);
            weapons.Add(dirk);
            weapons.Add(fireStaff);
            weapons.Add(frostStaff);
            weapons.Add(longBow);
            weapons.Add(recurvedBow);
            weapons.Add(blackPowderRifle);
            weapons.Add(laserRifle);

            #endregion


            //Players
            //Player Race, equippedweapon, MaxLife, Name, HitChance, Block, Life

            Player player0 = new Player(Race.Human, claymore, 30, "Rylan", 85, 20, 30);
            Player player1 = new Player(Race.Orc, battleAxe, 30, "Josh", 75, 35, 30);
            Player player2 = new Player(Race.Elf, recurvedBow, 30, "Rachel", 60, 50, 30);
            Player player3 = new Player(Race.Warlock, fireStaff, 30, "McKenna", 65, 55, 30);
            Player player4 = new Player(Race.Paladin, frostStaff, 40, "Iteara", 40, 80, 40);
            Player player5 = new Player(Race.ShapeShifter, dirk, 30, "Alivia", 50, 50, 30);
            Player player6 = new Player(Race.Cyborg, laserRifle, 30, "Ella", 80, 10, 30);

            //List<Player> player = new List<Player>();
            //player.Add(player0);
            //player.Add(player1);
            //player.Add(player2);
            //player.Add(player3);
            //player.Add(player4);
            //player.Add(player5);
            //player.Add(player6);


            bool exitChar = false;
                Player player = player0;
            do
            {
                Console.WriteLine("\nPlease select your character.\n");
                Console.WriteLine("A) Rylan\nB) Josh\nC) Rachel\nD) McKenna\nE) Iteara\nF) Alivia\nG) Ella\nX) Exit Game");
                string userChar = Console.ReadKey(true).Key.ToString().ToLower();
                Console.Clear();


                switch (userChar)
                {
                    case "a":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player0;
                        Console.WriteLine(player0);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                        case "b":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player1;
                        Console.WriteLine(player1);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                    case "c":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player2;
                        Console.WriteLine(player2);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                    case "d":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player3;
                        Console.WriteLine(player3);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                    case "e":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player4;
                        Console.WriteLine(player4);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                    case "f":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player5;
                        Console.WriteLine(player5);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                    case "g":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        player = player6;
                        Console.WriteLine(player6);
                        Console.ForegroundColor = ConsoleColor.White;
                        exitChar = true;
                        break;

                    case "x":
                        Console.WriteLine("\n\nThank you for playing the Dungeon Game\n\n");
                        goto endGame;
                        

                    default:
                        Console.WriteLine("\nThat was not a valid choice\n");
                        break;
                }


            } while (!exitChar);

            










            bool exit = false;

            do
            {
                Console.WriteLine(Room());

                //Life, Name, hit chance, block, life, min damage, max damage, Description
                Wolf rabidWolf = new Wolf(20, "Rabid Wolf", 50, 40, 20, 3, 16, "A wolf that is foaming out of his mouth");
                Wolf greyWolf = new Wolf(10, "Grey Wolf", 40, 20, 40, 1, 14, "An adult wolf");
                Wolf direWolf = new Wolf(25, "Dire Wolf", 40, 30, 70, 2, 20, "A big mangy wolf", true);
                Dragon greenDragon = new Dragon(10, "Green Dragon", 20, 20, 10, 2, 8, "A large green dragon");
                Dragon elderDragon = new Dragon(15, "Elder Dragon", 30, 25, 15, 3, 10, "A wise and fierce dragon", true);
                Serpent copperhead = new Serpent(10, "Copperhead", 35, 30, 6, 1, 10, "A coiled, hissing snake ready to strike", true);
                Serpent cobra = new Serpent(10, "Cobra", 40, 35, 10, 2, 12, "A Diamond back snake with venom dripping fangs", true);
                Dinosaur raptor = new Dinosaur(12, "Raptor", 30, 30, 12, 1, 8, "Quick and nimble with razor sharp claws", true);
                Dinosaur tyrannosaurusRex = new Dinosaur(20, "Tyrannosaurus Rex", 70, 40, 20, 4, 15, "The king of the Dinos");
                Dinosaur triceratops = new Dinosaur(12, "Triceratops", 40, 40, 12, 1, 5, "A stout Dino with Three horns");
                Wolf wolfPup = new Wolf();
                Dragon whiteDragon = new Dragon();
                Serpent garterSnake = new Serpent();
                Dinosaur babyDino = new Dinosaur();


                List<Monster> monsters = new List<Monster>();
                monsters.Add(greyWolf);
                monsters.Add(direWolf);
                monsters.Add(greenDragon);
                monsters.Add(elderDragon);
                monsters.Add(copperhead);
                monsters.Add(cobra);
                monsters.Add(raptor);
                monsters.Add(triceratops);
                monsters.Add(babyDino);
                monsters.Add(garterSnake);
                monsters.Add(wolfPup);
                monsters.Add(whiteDragon);
                monsters.Add(rabidWolf);
                monsters.Add(tyrannosaurusRex);

                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Count);
                Monster monster = monsters[randomNbr];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nIn this room you encounter: {monster.Name}");
                Console.ForegroundColor = ConsoleColor.White;


                bool reload = false;

                do
                {
                    Console.WriteLine("\nPlease select one of the following options");
                    Console.WriteLine("A) Attack\nR) Run away\nC) Character Information\nM) Monster Information\nX) Exit Game\nZ) Return to Main Menu");
                    string userChoice = Console.ReadKey(true).Key.ToString().ToLower();
                    Console.Clear();


                    switch (userChoice)
                    {

                        case "a":
                            Console.WriteLine("Attack\n");
                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine($"\nYou killed {monster.Name} ");

                                Console.ResetColor();

                                score++;

                                reload = true;
                            }
                            break;//break the fall!



                        //if withdraw, ask them for the amount to withdraw, and display the amount being withdrawn
                        case "r":
                            Console.WriteLine("Run away\n");
                            Console.WriteLine($"\n{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;//break the fall!


                        case "c":
                            Console.WriteLine(player);
                            Console.WriteLine($"\nMonsters defeated: {score}");
                            break;//break the fall!


                        case "m":
                            Console.WriteLine(monster);

                            break;//break the fall!


                        case "x":
                        case "e":
                        case "escape":
                            Console.WriteLine("\n\nThank you for playing the Dungeon Game\n\n");

                            exit = true;

                            break;//break the fall!

                        case "z":
                            goto mainMenu;


                        default:
                            Console.WriteLine("\nThat was not a valid option.\n");
                            break;
                    }//end switch

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("{0} has been slain!", player.Name);
                        exit = true;
                    }
                } while (!exit && !reload);

            } while (!exit);

            Console.WriteLine("\nYou defeated " + score + " monster" + ((score == 1) ? "." : "s.\n"));

        endGame:;


        }//end main()

        private static string Room()
        {

            string[] rooms =
            {
                "Your room is perched high on a cliffside with the wind swirling around you.",
                "The room is nearly pitch black, you hear sounds but can barely see your hand in front of your face.",
                "The room is watery and dank, it must be where all the waste comes to rest.",
                "The room has the acrid smell of sulfur, it is unbearably hot.",
                "The room is white with frost, you feel a spine tingling sensation creep up your back",


            };


            Random randomRoom = new Random();

            int indexNbr = randomRoom.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }//end Room()

    }//end class
}//end namespace
