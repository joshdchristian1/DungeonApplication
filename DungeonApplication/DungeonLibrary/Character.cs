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

        public int Life
        {
            get { return _life; }
            set
            {
                if (MaxLife > value )
                {
                    _life = value;
                }
                else
                {

                    _life = MaxLife;

                }
            }
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

        public virtual int CalcDamage()
        {
            return 0;
        }

        public virtual int CalcHitChance()
        {
            return 0;
        }

    }
    #endregion

    
}





