using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dinosaur : Monster
    {
        public bool IsCarnivore { get; set; }
        public Dinosaur(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, bool isCarnivore) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsCarnivore = isCarnivore;
        }

        public Dinosaur(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsCarnivore = false;
        }

        public Dinosaur()
        {
            Name = "Baby Dino";
            MaxLife = 10;
            Life = 10;
            HitChance = 40;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 5;
            Description = "Though just a hatchling, this dino is still dangerous.";
            IsCarnivore = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsCarnivore ? " This Dino eats only meat, he can rip through flesh" : " This dino has flat teeth for plants");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsCarnivore)
            {
                calculatedBlock += calculatedBlock / 2; 
            }

            return calculatedBlock;
        }

        
    }
}
