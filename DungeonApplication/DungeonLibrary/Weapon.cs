using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{


    public class Weapon
    {





        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _weaponType;


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
        public WeaponType WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }

                else
                {
                    _minDamage = 1;
                }

            }
        }

        public Weapon(WeaponType weaponType, string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            WeaponType = weaponType;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\nWeapon Type: {WeaponType}\nMin Damage: {MinDamage}\nMax Damage: {MaxDamage}\nBonus Hit Chance: {BonusHitChance}%\n{(IsTwoHanded ? "Two-handed" : "One-Handed")}");
        }
    }

}
