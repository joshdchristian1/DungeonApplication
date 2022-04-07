using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Monster : Character
    {
        //Fields
        private int _minDamage;

        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage && value > 0)
                {
                    _minDamage = value;
                }
                else
                {

                    _minDamage = 1;

                }
            }
        }

        //Constructor
        public Monster(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description) : base(maxLife, name, hitChance, block, life)
        {
        }
        //Methods
    }
}
