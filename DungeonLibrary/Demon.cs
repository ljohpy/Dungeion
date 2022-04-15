using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Demon : Monster
    {
        public bool IsVicious { get; set; }

        public Demon(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isVicious)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsVicious = isVicious;
        }

        public Demon()
        {
            Name = "Baby Demon";
            MaxLife = 10;
            Life = 10;
            HitChance = 40;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 5;
            Description = "Though just a baby, has been evil since birth.";
            IsVicious = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsVicious ? "Fire breathing eyes" : "Appears sweet, but don't trust a demon");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsVicious)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
