using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Dinosaur : Monster
    {
        public bool IsCarnivore { get; set; }
        public Dinosaur(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, bool isCarnivore, int armor) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description, armor)
        {
            IsCarnivore = isCarnivore;
        }

        public Dinosaur(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, int armor) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description, armor)
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
            Description = "Just a baby, but this Dino is still dangerous.";
            IsCarnivore = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsCarnivore ? " This Dino eats only meat, he can rip through flesh" : " This Dino is a plant-eater");
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
