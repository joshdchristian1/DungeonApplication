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
            Console.SetWindowSize(140, 40);
            Console.Title = "Dungeon Game";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            // Console.WriteLine("Welcome to the Dungeon, It gets worse here everyday!\n");
            Console.WriteLine(@"
     _    _        _                                _           _    _            ______                                          
    | |  | |      | |                              | |         | |  | |           |  _  \                                         
    | |  | |  ___ | |  ___  ___   _ __ ___    ___  | |_  ___   | |_ | |__    ___  | | | | _   _  _ __    __ _   ___   ___   _ __  
    | |/\| | / _ \| | / __|/ _ \ | '_ ` _ \  / _ \ | __|/ _ \  | __|| '_ \  / _ \ | | | || | | || '_ \  / _` | / _ \ / _ \ | '_ \ 
    \  /\  /|  __/| || (__| (_) || | | | | ||  __/ | |_| (_) | | |_ | | | ||  __/ | |/ / | |_| || | | || (_| ||  __/| (_) || | | |
     \/  \/  \___||_| \___|\___/ |_| |_| |_| \___|  \__|\___/   \__||_| |_| \___| |___/   \__,_||_| |_| \__, | \___| \___/ |_| |_|
                                                                                                         __/ |                    
                                                                                                        |___/                     
");
            Console.WriteLine(@"

                            

                               (                                                                                      
                               )\ )      )                       )                                                    
                              (()/(   ( /(     (  (      (    ( /(          (  (           (            (             
                               /(_))  )\())    )\))(    ))\   )\())  (      )\))(     (    )(    (     ))\            
                              (_))   (_))/    ((_))\   /((_) (_))/   )\    ((_)()\    )\  (()\   )\   /((_)           
                              |_ _|  | |_      (()(_) (_))   | |_   ((_)   _(()((_)  ((_)  ((_) ((_) (_))             
                               | |   |  _|    / _` |  / -_)  |  _|  (_-<   \ V  V / / _ \ | '_| (_-< / -_)            
                              |___|   \__|    \__, |  \___|   \__|  /__/    \_/\_/  \___/ |_|   /__/ \___|            
                                              |___/                                                                  
                                                                                                                  
                              )                                                               (                   
                           ( /(     (    (       (        (      )       (    (     (         )\ )      )   (     
                           )\())   ))\   )(     ))\      ))\    /((     ))\   )(    )\ )     (()/(   ( /(   )\ )  
                          ((_)\   /((_) (()\   /((_)    /((_)  (_))\   /((_) (()\  (()/(      ((_))  )(_)) (()/(  
                          | |(_) (_))    ((_) (_))     (_))    _)((_) (_))    ((_)  )(_))     _| |  ((_)_   )(_)) 
                          | ' \  / -_)  | '_| / -_)    / -_)   \ V /  / -_)  | '_| | || |   / _` |  / _` | | || | 
                          |_||_| \___|  |_|   \___|    \___|    \_/   \___|  |_|    \_, |   \__,_|  \__,_|  \_, | 
                                                                                    |__/                    |__/  
                      

");

            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
            Console.Clear();

        //PlaySong();


        mainMenu:


            int score = 0;

            #region Weapons


            //Weapons
            //Type, Name, Min Damage, Max Damage, Bonus Hit Chance, Two Handed
            Weapon generic = new Weapon(WeaponType.Axe, "Generic", 1, 2, 2, false);
            Weapon claymore = new Weapon(WeaponType.Sword, "Claymore", 3, 12, 0, true);
            Weapon rapier = new Weapon(WeaponType.Sword, "Rapier", 1, 8, 20, false);
            Weapon battleAxe = new Weapon(WeaponType.Axe, "Battle Axe", 5, 20, 0, true);
            Weapon vikingAxe = new Weapon(WeaponType.Axe, "Viking Axe", 1, 6, 30, false);
            Weapon stiletto = new Weapon(WeaponType.Dagger, "Stiletto", 1, 4, 40, false);
            Weapon dirk = new Weapon(WeaponType.Dagger, "Dirk", 1, 5, 35, false);
            Weapon fireStaff = new Weapon(WeaponType.Staff, "Fire Staff", 1, 10, 20, false);
            Weapon frostStaff = new Weapon(WeaponType.Staff, "Frost Staff", 3, 15, 0, false);
            Weapon longBow = new Weapon(WeaponType.Bow, "Long Bow", 1, 6, 15, true);
            Weapon recurvedBow = new Weapon(WeaponType.Bow, "Recurved Bow", 1, 9, 10, true);
            Weapon blackPowderRifle = new Weapon(WeaponType.Rifle, "Black Powder Rife", 5, 12, 5, true);
            Weapon laserRifle = new Weapon(WeaponType.Rifle, "Laser Rifle", 3, 10, 6, true);
            Weapon winchester1887 = new Weapon(WeaponType.Rifle, "Winchester Model 1887", 1, 20, 20, false);

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
            //Player Race, equippedweapon, MaxLife, Name, HitChance, Block, Life, Armor

            Player player0 = new Player(Race.Generic, generic, 30, "Rylan", 85, 15, 30, 0);
            Player player1 = new Player(Race.Generic, generic, 30, "Josh", 75, 25, 30, 0);
            Player player2 = new Player(Race.Generic, generic, 30, "Rachel", 60, 40, 30, 0);
            Player player3 = new Player(Race.Generic, generic, 30, "McKenna", 65, 35, 30, 0);
            Player player4 = new Player(Race.Generic, generic, 40, "Iteara", 70, 30, 40, 0);
            Player player5 = new Player(Race.Generic, generic, 35, "Alivia", 80, 20, 35, 0);
            Player player6 = new Player(Race.Generic, generic, 30, "Ella", 68, 32, 30, 0);
            Player player7 = new Player(Race.Cyborg, winchester1887, 100, "T-800 Terminator", 100, 40, 100, 0);

            List<Player> userPlayers = new List<Player>() { player0, player1, player2, player3, player4, player5, player6 };


            #region Character Select Menu


            bool exitChar = false;
            Player player = player0;
            do
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"
 _____  _                               _              
/  __ \| |                             | |             
| /  \/| |__    __ _  _ __  __ _   ___ | |_  ___  _ __ 
| |    | '_ \  / _` || '__|/ _` | / __|| __|/ _ \| '__|
| \__/\| | | || (_| || |  | (_| || (__ | |_|  __/| |   
 \____/|_| |_| \__,_||_|   \__,_| \___| \__|\___||_|   
                                                       
                                                       
");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease select your character.\n");
                Console.WriteLine("A) Rylan\nB) Josh\nC) Rachel\nD) McKenna\nE) Iteara\nF) Alivia\nG) Ella\nZ) Show Player Stats\nEsc) Exit Game");
                string userChar = Console.ReadKey(true).Key.ToString().ToLower();
                Console.Clear();


                switch (userChar)
                {
                    case "a":

                        player = player0;

                        exitChar = true;
                        break;

                    case "b":

                        player = player1;

                        exitChar = true;
                        break;

                    case "c":

                        player = player2;

                        exitChar = true;
                        break;

                    case "d":

                        player = player3;

                        exitChar = true;
                        break;

                    case "e":

                        player = player4;

                        exitChar = true;
                        break;

                    case "f":

                        player = player5;

                        exitChar = true;
                        break;

                    case "g":

                        player = player6;

                        exitChar = true;
                        break;

                    case "q":

                        player = player7;
                        goto hiddenStart;


                    case "z":

                        foreach (var item in userPlayers)
                        {
                            Console.WriteLine($"Name: {item.Name}\nMax Life: {item.MaxLife}\nHit Chance: {item.HitChance}\nBlock: {item.Block} \n");
                        }
                        break;

                    case "escape":
                        Console.WriteLine("\n\nThank you for playing the Dungeon Game\n\n");
                        goto endGame;


                    default:
                        Console.WriteLine("\nThat was not a valid choice\n");
                        break;
                }


            } while (!exitChar);





            #endregion


            bool exitRace = false;

            List<Race> userRaceSelection = new List<Race>() { Race.Human, Race.Elf, Race.Orc, Race.Warlock, Race.Paladin, Race.ShapeShifter, Race.Cyborg };

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"
______                    
| ___ \                   
| |_/ /  __ _   ___   ___ 
|    /  / _` | / __| / _ \
| |\ \ | (_| || (__ |  __/
\_| \_| \__,_| \___| \___|
                          
                          
");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease select your Race.\n");
                Console.WriteLine("A) Human (+5 Hit Chance) & (+ 5 Block)\nB) Elf (+ 2 Block) & (+ 15 Hit Chance When using Ranged Weapons)\nC) Orc (+ 5 to Max Weapon Damage)\nD) Warlock (+ 5 Hit Chance) & (+ 5 Max Life) & (+ 5 Max Weapon Damage when using a Staff)\nE) Paladin (+ 15 Armor)\nF) Shapeshifter (+ 10 Block)\nG) Cyborg (+ 10 Hit Chance)\nX) Back to Character Selection Menu\nESC) Quit Game");
                string userRace = Console.ReadKey(true).Key.ToString().ToLower();
                Console.Clear();


                switch (userRace)
                {
                    case "a":
                        player.CharacterRace = Race.Human;
                        player.HitChance += 5;
                        player.Block += 5;
                        exitRace = true;
                        break;

                    case "b":
                        player.CharacterRace = Race.Elf;
                        player.Block += 2;
                        exitRace = true;
                        break;

                    case "c":
                        player.CharacterRace = Race.Orc;
                        player.EquippedWeapon.MaxDamage += 5;
                        exitRace = true;
                        break;

                    case "d":
                        player.CharacterRace = Race.Warlock;
                        player.HitChance += 5;
                        player.MaxLife += 5;
                        player.Life += 5;
                        exitRace = true;
                        break;

                    case "e":
                        player.CharacterRace = Race.Paladin;
                        player.Armor += 15;
                        exitRace = true;
                        break;

                    case "f":
                        player.CharacterRace = Race.ShapeShifter;
                        player.Block += 15;
                        exitRace = true;
                        break;

                    case "g":
                        player.CharacterRace = Race.Cyborg;
                        player.HitChance += 10;
                        player.Armor += 5;
                        exitRace = true;
                        break;



                    case "x":
                        Console.WriteLine("\n\nBack to Character Selection Menu\n\n");
                        goto mainMenu;

                    case "escape":
                        goto endGame;


                    default:
                        Console.WriteLine("\nThat was not a valid choice\n");
                        break;
                }


            } while (!exitRace);

            bool exitWeapon = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"
 _    _                                   
| |  | |                                  
| |  | |  ___   __ _  _ __    ___   _ __  
| |/\| | / _ \ / _` || '_ \  / _ \ | '_ \ 
\  /\  /|  __/| (_| || |_) || (_) || | | |
 \/  \/  \___| \__,_|| .__/  \___/ |_| |_|
                     | |                  
                     |_|                  
");
                Console.ForegroundColor = ConsoleColor.White;


                Console.WriteLine("\nPlease select your Weapon.\n");
                Console.WriteLine("A) Claymore\nB) Rapier\nC) Battle Axe\nD) Viking Axe\nE) Stiletto\nF) Dirk\nG) Fire Staff\nH) Frost Staff\nI) Long Bow\nJ) Recurved Bow\nK) Black Powder Rifle\nL) Laser Rifle\nZ) Show Weapon Stats\nX) Back to Character Selection Menu");
                string userWeapon = Console.ReadKey(true).Key.ToString().ToLower();
                Console.Clear();

                switch (userWeapon)
                {
                    case "a":
                        player.EquippedWeapon = claymore;
                        exitWeapon = true;
                        break;

                    case "b":
                        player.EquippedWeapon = rapier;
                        exitWeapon = true;
                        break;

                    case "c":
                        player.EquippedWeapon = battleAxe;
                        exitWeapon = true;
                        break;

                    case "d":
                        player.EquippedWeapon = vikingAxe;
                        exitWeapon = true;
                        break;

                    case "e":
                        player.EquippedWeapon = stiletto;
                        exitWeapon = true;
                        break;

                    case "f":
                        player.EquippedWeapon = dirk;
                        exitWeapon = true;
                        break;

                    case "g":
                        player.EquippedWeapon = fireStaff;
                        exitWeapon = true;
                        break;

                    case "h":
                        player.EquippedWeapon = frostStaff;
                        exitWeapon = true;
                        break;

                    case "i":
                        player.EquippedWeapon = longBow;
                        exitWeapon = true;
                        break;

                    case "j":
                        player.EquippedWeapon = recurvedBow;
                        exitWeapon = true;
                        break;

                    case "k":
                        player.EquippedWeapon = blackPowderRifle;
                        exitWeapon = true;
                        break;

                    case "l":
                        player.EquippedWeapon = laserRifle;
                        exitWeapon = true;
                        break;

                    case "x":
                        Console.WriteLine("\n\nBack to Character Selection Menu\n\n");
                        goto mainMenu;

                    case "z":
                        foreach (var item in weapons)
                        {
                            Console.WriteLine(item + "\n");
                        }
                        break;


                    default:
                        Console.WriteLine("\nThat was not a valid choice\n");
                        break;
                }


            } while (!exitWeapon);

            if (player.CharacterRace == Race.Orc)
            {
                player.EquippedWeapon.MaxDamage += 5;
            }

            else if (player.CharacterRace == Race.Elf && player.EquippedWeapon == longBow || player.EquippedWeapon == recurvedBow || player.EquippedWeapon == blackPowderRifle || player.EquippedWeapon == laserRifle)
            {
                player.HitChance += 15;
            }

            else if (player.CharacterRace == Race.Warlock && player.EquippedWeapon == frostStaff || player.EquippedWeapon == fireStaff)
            {
                player.EquippedWeapon.MaxDamage += 5;
            }

        hiddenStart:

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(player);
            Console.ForegroundColor = ConsoleColor.White;




            int healthPotion = 2;




            bool exit = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n" + Room() + "\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                //Life, Name, hit chance, block, life, min damage, max damage, Description
                Wolf rabidWolf = new Wolf(20, "Rabid Wolf", 50, 40, 20, 3, 16, "A wolf that is foaming out of his mouth.", 0);
                Wolf greyWolf = new Wolf(10, "Grey Wolf", 40, 20, 40, 1, 14, "An adult wolf.", 0);
                Wolf direWolf = new Wolf(25, "Dire Wolf", 40, 30, 70, 2, 20, "A big mangy wolf.", true, 0);
                Dragon greenDragon = new Dragon(12, "Green Dragon", 20, 20, 10, 2, 8, "A large green dragon.", 0);
                Dragon elderDragon = new Dragon(17, "Elder Dragon", 30, 25, 15, 3, 10, "A wise and fierce dragon.", true, 0);
                Serpent copperhead = new Serpent(13, "Copperhead", 35, 30, 6, 1, 10, "A coiled, hissing snake ready to strike.", true, 0);
                Serpent cobra = new Serpent(15, "Cobra", 40, 35, 10, 2, 12, "A hooded snake with dripping fangs.", true, 0);
                Dinosaur raptor = new Dinosaur(12, "Raptor", 30, 30, 12, 1, 8, "Quick and nimble with razor sharp claws.", true, 0);
                Dinosaur tyrannosaurusRex = new Dinosaur(20, "Tyrannosaurus Rex", 70, 40, 20, 4, 15, "The king of the Dinos.", true, 0);
                Dinosaur triceratops = new Dinosaur(12, "Triceratops", 40, 40, 12, 1, 5, "A stout Dino with Three horns.", 0);
                Wolf wolfPup = new Wolf();
                Dragon whiteDragon = new Dragon();
                Serpent garterSnake = new Serpent();
                Dinosaur babyDino = new Dinosaur();
                Boss scaryTerry = new Boss();
                Boss amazonians = new Boss(40, "Amazonian Woman", 80, 10, 40, 1, 15, "Death by Snu-Snu!", 0);


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


                if (score == 10)
                {
                    Console.Clear();
                    monster = scaryTerry;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                       __________                      ___________.__       .__     __                          
  /\|\/\       .__     \______   \ ____  ______ ______ \_   _____/|__| ____ |  |___/  |_     .__       /\|\/\   
 _)    (__   __|  |___  |    |  _//  _ \/  ___//  ___/  |    __)  |  |/ ___\|  |  \   __\  __|  |___  _)    (__ 
 \_     _/  /__    __/  |    |   (  <_> )___ \ \___ \   |     \   |  / /_/  >   Y  \  |   /__    __/  \_     _/ 
   )    \      |__|     |______  /\____/____  >____  >  \___  /   |__\___  /|___|  /__|      |__|       )    \  
   \/\|\/                      \/           \/     \/       \/      /_____/      \/                     \/\|\/  
");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nIn this room you encounter: {monster.Name}\n");
                    Console.ForegroundColor = ConsoleColor.White;


                }
                else if (score == 20)
                {

                    Console.Clear();
                    monster = amazonians;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                       __________                      ___________.__       .__     __                          
  /\|\/\       .__     \______   \ ____  ______ ______ \_   _____/|__| ____ |  |___/  |_     .__       /\|\/\   
 _)    (__   __|  |___  |    |  _//  _ \/  ___//  ___/  |    __)  |  |/ ___\|  |  \   __\  __|  |___  _)    (__ 
 \_     _/  /__    __/  |    |   (  <_> )___ \ \___ \   |     \   |  / /_/  >   Y  \  |   /__    __/  \_     _/ 
   )    \      |__|     |______  /\____/____  >____  >  \___  /   |__\___  /|___|  /__|      |__|       )    \  
   \/\|\/                      \/           \/     \/       \/      /_____/      \/                     \/\|\/  
");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nIn this room you encounter: {monster.Name}\n");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                else
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nIn this room you encounter: {monster.Name}\n");
                    Console.ForegroundColor = ConsoleColor.White;

                }




                bool reload = false;

                do
                {
                    Console.WriteLine("\nPlease select one of the following options\n");
                    Console.WriteLine("A) Attack\nR) Run away\nC) Character Information\nM) Monster Information\nP) Use Health Potion\nX) Exit Game\nZ) Return to Main Menu\n\n");
                    string userChoice = Console.ReadKey(true).Key.ToString().ToLower();
                    Console.Clear();


                    switch (userChoice)
                    {

                        case "a":
                            if (monster.Name.ToLower().Contains("scary") || monster.Name.ToLower().Contains("amazon"))
                            {

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(@"
                       __________                      ___________.__       .__     __                          
  /\|\/\       .__     \______   \ ____  ______ ______ \_   _____/|__| ____ |  |___/  |_     .__       /\|\/\   
 _)    (__   __|  |___  |    |  _//  _ \/  ___//  ___/  |    __)  |  |/ ___\|  |  \   __\  __|  |___  _)    (__ 
 \_     _/  /__    __/  |    |   (  <_> )___ \ \___ \   |     \   |  / /_/  >   Y  \  |   /__    __/  \_     _/ 
   )    \      |__|     |______  /\____/____  >____  >  \___  /   |__\___  /|___|  /__|      |__|       )    \  
   \/\|\/                      \/           \/     \/       \/      /_____/      \/                     \/\|\/  
");
                                Console.ForegroundColor = ConsoleColor.Yellow;

                            }

                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(@"
______         _    _    _         _____  _                  
| ___ \       | |  | |  | |       |_   _|(_)                 
| |_/ /  __ _ | |_ | |_ | |  ___    | |   _  _ __ ___    ___ 
| ___ \ / _` || __|| __|| | / _ \   | |  | || '_ ` _ \  / _ \
| |_/ /| (_| || |_ | |_ | ||  __/   | |  | || | | | | ||  __/
\____/  \__,_| \__| \__||_| \___|   \_/  |_||_| |_| |_| \___|                                                             
                                                             
");


                            }

                            Console.ForegroundColor = ConsoleColor.DarkCyan;


                            // Console.WriteLine(player);
                            Console.WriteLine($"{player.Name}....................VS.......................{monster.Name} \n");

                            Console.ForegroundColor = ConsoleColor.White;


                            //Console.ForegroundColor = ConsoleColor.White;


                            if (player.EquippedWeapon == dirk || player.EquippedWeapon == stiletto || player.EquippedWeapon == vikingAxe)
                            {
                                Combat.MultiHit(player, monster);
                            }
                            Combat.DoBattle(player, monster);




                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine($"\nYou killed {monster.Name} \n");

                                Console.ResetColor();

                                score++;

                                Random lootDrop = new Random();
                                int lootRoll = lootDrop.Next(1, 101);

                                if (monster.Name.ToLower().Contains("scary") || monster.Name.ToLower().Contains("amazon"))
                                {
                                    healthPotion += 2;
                                    player.Armor += 15;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(monster.Name + " dropped 2 Health Potions! You now have " + healthPotion + " Health Potion" + ((healthPotion == 1) ? "." : "s.\n"));
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(monster.Name + " dropped some armor! You now have " + player.Armor + " Armor.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }


                                else if (lootRoll >= 85)
                                {
                                    healthPotion += 1;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(monster.Name + " dropped a Health Potion! You now have " + healthPotion + " Health Potion" + ((healthPotion == 1) ? "." : "s.\n"));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                else if (lootRoll <= 10)
                                {
                                    player.Armor += 5;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(monster.Name + " dropped some armor! You now have " + player.Armor + " Armor.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }



                                reload = true;
                            }

                            break;//break the fall!



                        //if withdraw, ask them for the amount to withdraw, and display the amount being withdrawn
                        case "r":
                            Console.WriteLine(@"
______                  ___                          
| ___ \                / _ \                         
| |_/ / _   _  _ __   / /_\ \__      __  __ _  _   _ 
|    / | | | || '_ \  |  _  |\ \ /\ / / / _` || | | |
| |\ \ | |_| || | | | | | | | \ V  V / | (_| || |_| |
\_| \_| \__,_||_| |_| \_| |_/  \_/\_/   \__,_| \__, |
                                                __/ |
                                               |___/ 

");

                            Console.WriteLine($"\n{monster.Name} attacks you as you flee!\n");
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;//break the fall!


                        case "c":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine(@"
 _____  _                               _              
/  __ \| |                             | |             
| /  \/| |__    __ _  _ __  __ _   ___ | |_  ___  _ __ 
| |    | '_ \  / _` || '__|/ _` | / __|| __|/ _ \| '__|
| \__/\| | | || (_| || |  | (_| || (__ | |_|  __/| |   
 \____/|_| |_| \__,_||_|   \__,_| \___| \__|\___||_|   
                                                       
                                                       
");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(player);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have " + healthPotion + " Health Potion" + ((healthPotion == 1) ? "" : "s") + " remaining.\n");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine($"\nMonsters defeated: {score}");
                            break;//break the fall!


                        case "m":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(@"
___  ___                    _               
|  \/  |                   | |              
| .  . |  ___   _ __   ___ | |_   ___  _ __ 
| |\/| | / _ \ | '_ \ / __|| __| / _ \| '__|
| |  | || (_) || | | |\__ \| |_ |  __/| |   
\_|  |_/ \___/ |_| |_||___/ \__| \___||_|   
                                            
                                            
");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(monster);
                            Console.ForegroundColor = ConsoleColor.White;

                            break;//break the fall!

                        case "p":
                            if (healthPotion == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"You do not have any Health Potions!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (player.Life == player.MaxLife)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Your Health is already full!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                player.Life += 10;
                                healthPotion--;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have restored 10 Health Points. You have " + healthPotion + " Health Potion" + ((healthPotion == 1) ? "" : "s") + " remaining.\n");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            break;


                        case "x":
                        case "e":
                        case "escape":
                            Console.WriteLine("\n\nThank you for playing the Dungeon Game\n\n");

                            exit = true;

                            break;//break the fall!

                        case "z":
                            goto mainMenu;


                        default:
                            Console.WriteLine("\nThat was not a valid option.\n\n");
                            break;
                    }//end switch

                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("{0} has been slain!", player.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Would you like to play again? Y/N");
                        string playAgain = Console.ReadKey(true).Key.ToString().ToLower();
                        if (playAgain == "y")
                        {
                            Console.Clear();
                            goto mainMenu;
                        }
                        else if (playAgain == "n")
                        {
                            exit = true;

                        }


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
                "The room is perched high on a cliffside with the wind swirling around you.",
                "The room is nearly pitch black, you hear sounds but can barely see your hand in front of your face.",
                "The room is watery and dank, it must be where all the waste comes to rest.",
                "The room has the acrid smell of sulfur, it is unbearably hot.",
                "The room is white with frost, you feel a spine tingling sensation creep up your back",
                "The room has a disorienting effect...Your senses are warped, your balance is shifting",
                "The room's walls are trickling a dark red substance...Better stick to the center of the room"


            };



            Random randomRoom = new Random();

            int indexNbr = randomRoom.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }//end Room()
        public static void PlaySong()
        {
            Console.Beep(987, 153);
            Console.Beep(987, 153);
            Console.Beep(987, 153);
            Console.Beep(987, 900);
            Console.Beep(784, 900);
            Console.Beep(880, 900);
            Console.Beep(987, 700);
            Console.Beep(880, 300);
            Console.Beep(987, 700);
            Thread.Sleep(500);
        }

    }//end class
}//end namespace
