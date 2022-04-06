using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DungeonLibrary
{


    #region Character

    public class Character
    {

        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;


        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Life
        {
            get { return _life; }
            set
            {
                if (Life > MaxLife)
                {
                    _life = MaxLife;
                }
                else
                {

                    _life = value;

                }
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }


        public Character(int maxLife, string name, int hitChance, int block, int life)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;

        }


        public override string ToString()
        {
            return string.Format($"Current Health: {Life} out of {MaxLife}\nName: {Name}\nHit Chance: {HitChance}\nBlock: {Block}\n");
        }

        public int CalBlock()
        {


            return Block;
        }

        public int CalcDamage()
        {
            return 0;
        }

    }
    #endregion

    #region Weapon

    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;


        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (MinDamage > MaxDamage)
                {
                    _minDamage = MaxDamage;
                }

                else
                {
                    _minDamage = value;
                }

            }
        }

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        public override string ToString()
        {
            return string.Format($"Weapon Name: {Name}\nMin Damage: {MinDamage}\nMax Damage: {MaxDamage}\nBonus Hit Chance: {BonusHitChance}\nTwo Handed Weapon? {IsTwoHanded}");
        }
    }

    #endregion

}





