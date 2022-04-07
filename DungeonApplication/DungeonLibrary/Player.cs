using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields


        //Properties
        public Race Race { get; set; }

        public Weapon Weapon { get; set; }

        //Constructor

        public Player(Race race, Weapon weapon, int maxLife, string name, int hitChance, int block, int life) : base(maxLife, name, hitChance, block, life)
        {
            Race = race;
            Weapon = weapon;
        }

        //Methods
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(Weapon.MinDamage, Weapon.MaxDamage);
            return (damage);//random value between the Equipped Weapon's min and max damage amount;
        }

        public override int CalcHitChance()
        {
            return (base.CalcHitChance() + Weapon.BonusHitChance); //calculation that includes base.CalHitChance() plus the Equipped Weapons bonus hit chance
        }

        public override string ToString()
        {
            string[] raceDescriptions =
            {
                "A lifeform that makes up for its fragile frame with raw brutality",
                "A noble creature small in stature with a fondness of ranged weapons",
                "A brutish warrior, whose large frame is perfect for dealing out damage",
                "A humanoid creature who deals in the dark arts",
                "A humanoid creature with a suit of armor who deals in white magic",
                "A polymorphic being hell-bent on destruction",
                "Half man, half machine, cold, calculating and deadly efficient"
            };
                bool exit = false;
            do
            {



                switch (userRaceChoice)
                {
                    case "Human":
                        Console.WriteLine(raceDescriptions[0]);
                        break;

                    case "Elf":
                        Console.WriteLine(raceDescriptions[1]);
                        break;

                    case "Orc":
                        Console.WriteLine(raceDescriptions[2]);
                        break;

                    case "Warlock":
                        Console.WriteLine(raceDescriptions[3]);
                        break;

                    case "Paladin":
                        Console.WriteLine(raceDescriptions[4]);
                        break;

                    case "Shapeshifter":
                        Console.WriteLine(raceDescriptions[5]);
                        break;

                    case "Cyborg":
                        Console.WriteLine(raceDescriptions[6]);
                        break;


                    default:
                        Console.WriteLine("That was not a valid choice");
                        break;
                } 

            } while (!exit);
            //return base.ToString();
            //Decrip based on char race before the return string.Format() and thinking about which branching logic is best suited for exact matching(switch).
        }

    }
}
