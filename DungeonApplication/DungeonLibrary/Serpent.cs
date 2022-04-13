using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Serpent : Monster
    {
        public bool IsVenomous { get; set; }
        public Serpent(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, bool isVenomous) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsVenomous = isVenomous;
        }

        public Serpent(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsVenomous = false;
        }

        public Serpent()
        {
            Name = "Garter Snake";
            MaxLife = 10;
            Life = 10;
            HitChance = 40;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 5;
            Description = "A common snake";
            IsVenomous = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsVenomous ? ". Venom make this snake ever more deadly" : ". This is a Non-venomous");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsVenomous)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

       
    }
}
