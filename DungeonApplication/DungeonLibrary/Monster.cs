using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Monster : Character
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
        public Monster(int maxLife, string name, int hitChance, int block, int life, int minDamage, int maxDamage, string description, int armor) : base(maxLife, name, hitChance, block, life, armor)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster () { }
        //Methods
        public override string ToString()
        {
            return string.Format($"\n*--------{Name}---------*\nLife: {Life} of {MaxLife}\nDamage: {MinDamage} to {MaxDamage}\nDescription: {Description}");
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }

    }
}
