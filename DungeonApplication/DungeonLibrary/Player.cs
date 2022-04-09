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
        public Race CharacterRace { get; set; }

        public Weapon EquippedWeapon { get; set; }

        //Constructor

        public Player(Race characterRace , Weapon equippedweapon, int maxLife, string name, int hitChance, int block, int life) : base(maxLife, name, hitChance, block, life)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedweapon;

            #region Potential Expansion - Racial Bonuses

            //switch (CharacterRace)
            //{
            //    case Race.Elf:
            //        HitChance += 5;
            //        break;
            //}

            #endregion
        }

        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Human:
                    description = "Human, A lifeform that makes up for its fragile frame with raw brutality\n";
                    break;
                case Race.Elf:
                    description = "Elf, A noble creature small in stature with a fondness of ranged weapons\n";
                    break;
                case Race.Orc:
                    description = "Orc, A brutish warrior, whose large frame is perfect for dealing out damage\n";
                    break;
                case Race.Warlock:
                    description = "Warlock, A humanoid creature who deals in the dark arts\n";
                    break;
                case Race.Paladin:
                    description = "Paladin, A humanoid creature with a suit of armor who deals in white magic\n";
                    break;
                case Race.ShapeShifter:
                    description = "Shapeshifter, A polymorphic being hell-bent on destruction\n";
                    break;
                case Race.Cyborg:
                    description = "Cyborg, Half man, half machine, cold, calculating and deadly efficient\n";
                    break;
                
            }//end switch

            return string.Format($" *-=-={Name}=-=-*\nLife: {Life} of {MaxLife}\nHit Chance: {HitChance}%\nWeapon: {EquippedWeapon}\nBlock: {Block}\nDescription: {description}");
        
        
        }//end override


        //Methods
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return (base.CalcHitChance() + EquippedWeapon.BonusHitChance); 
        }

        

    }
}
