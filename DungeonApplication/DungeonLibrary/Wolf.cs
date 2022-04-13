using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Wolf : Monster
    {
        //Fields

        //Properties
        public bool IsDire { get; set; }

        //Constructor
        public Wolf(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, bool isDire) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsDire = isDire;

        }

        public Wolf(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsDire = false;

        }

        public Wolf()
        {
            Name = "Wolf Pup";
            MaxLife = 10;
            Life = 10;
            HitChance = 40;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 5;
            Description = "A Young Wolf";
            IsDire = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsDire ? ". This is a dire wolf" : " of average size.");
        }



        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsDire)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

        
    }
}
