using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Boss : Monster
    {
        //public bool IsCarnivore { get; set; }
        public Boss(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, bool isCarnivore, int armor) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description, armor)
        {
           // IsCarnivore = isCarnivore;
        }

        public Boss(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, int armor) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description, armor)
        {
            //IsCarnivore = false;
        }

        public Boss()
        {
            Name = "Scary Terry";
            MaxLife = 30;
            Life = 30;
            HitChance = 60;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 15;
            Description = "You can run but you can't hide!";
            Armor = 0;
            //IsCarnivore = false;
        }

        

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            
            
                calculatedBlock += calculatedBlock / 2;
            

            return calculatedBlock;
        }


    }
}
