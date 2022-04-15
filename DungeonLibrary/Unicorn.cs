using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Unicorn : Monster
    {
        public bool IsFluffy { get; set; }

        public Unicorn(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isFluffy)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsFluffy = isFluffy;
        }

        public Unicorn()
        {
            Name = "Baby Unicorn";
            MaxLife = 8;
            Life = 8;
            HitChance = 30;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 4;
            Description = "It's so cute!";
            IsFluffy = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "Fluffy" : "Not so fluffy");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

           
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
