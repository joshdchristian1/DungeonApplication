using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {

        //This is NOT a datatype class, so it won't have 
        //fields, properties, or constructors. It will 
        //simply serve as a warehoulse for a variety of
        //methods related to combat.

        //Let's create a method to handle a one-sided attack

        public static void DoAttack(Character attacker, Character defender)
        {
            //Get a random number from 1-100
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            //Nothing is TRULY random in programing, but suspending
            //the code execution briefly may help simulate "randomness"
            //We can Tread.Sleep() for this, which is located in the 
            //System.Threading namespace.

            Thread.Sleep(30);
            int armorOverflow = 0;
            //If the attacker "hits"
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculate the damage
                int damageDealt = attacker.CalcDamage();

                //Subtract & assign the damage to the defender's life
                if (defender.Armor != 0 && defender.Armor > damageDealt)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYour Armor absorbed some damage!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    defender.Armor -= damageDealt;

                }

                else if (defender.Armor != 0 && defender.Armor - damageDealt < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nYour Armor absorbed some damage, but that still hurt!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    armorOverflow = damageDealt - defender.Armor;
                    defender.Armor -= damageDealt;
                    defender.Life -= armorOverflow;

                }

                else
                {

                    defender.Life -= damageDealt;
                }

                //Output the result - Red text helps indicate damage
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!\n", attacker.Name, defender.Name, damageDealt);

                //Reset the color
                Console.ResetColor();
            }
            //if the attacker "missed"
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }//end do attack

        //Now we can create a method to handle battle - attacks from both sides
        public static void DoBattle(Player player, Monster monster)
        {

            //Possible Expansion
            //Consider adding an Initiative property to Character
            //if (player.Initative >= monster.Initative)
            //{
            //      DoAttack(player, monster)
            //}


            //For this example, we'll grant the Player "initiative" by default aka player goes first

            DoAttack(player, monster);

            //If the Monster survives, they will attack the player back
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }


        }
        public static void MultiHit(Player player, Monster monster)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);
            if (roll >= 80)
            {
                Console.WriteLine($"The training with your {player.EquippedWeapon.Name} allowed you to strike twice!\n");
                DoAttack(player, monster);


            }
            else if (roll <= 7)
            {
                Console.WriteLine($"Nice work with your {player.EquippedWeapon.Name}. You struck three times!\n");
                DoAttack(player, monster);
                DoAttack(player, monster);
            }

            //if (monster.Life > 0)
            //{

            //    DoAttack(monster, player);
            //}

        }
    }
}
