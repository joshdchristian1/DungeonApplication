using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Dragon : Monster
    {
        public bool IsFlying { get; set; }
        public Dragon(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, bool isFlying) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsFlying = isFlying;
        }

        public Dragon(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description) : base(maxLife, name, hitChance, block, life, minDamage, maxDamage, description)
        {
            IsFlying = false;
        }

        public Dragon()
        {
            Name = "White Dragon";
            MaxLife = 10;
            Life = 10;
            HitChance = 20;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 3;
            Description = "A Winged Beast with scales of Ivory";
            IsFlying = false;

        }

        public override string ToString()
        {
            return base.ToString() + (IsFlying ? " .The Dragon has taken flight" : " .The Dragon has remained Earthbound");
        }


        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsFlying)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

       

    }
}
