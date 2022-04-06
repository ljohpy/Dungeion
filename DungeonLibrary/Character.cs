namespace DungeonLibrary
{
    public class Character
    {
        //Fields
        private string _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        
        //Properties
        public string Life
        {
            get { return _life; }
            set { _life = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
         }
        public int HitChance
        {
            get { return _hitChance;}
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; } 
        }
        public int MaxLife
        {
            get { return _maxLife;}
            set { _maxLife = value; }
        }
        

        //Constructors
        public Character (int life, string name, int hitchance, int block, int maxlife)
        {
            Life = Life;
            Name = name;
            hitchance = hitchance;
            Block = block;
            MaxLife = maxlife;

        }

        //Methods
        public int CalcBlock()
        {
            return _block;
        }

        public int CalcHitChance()
        {
            return HitChance;
        }

        public int CalcDamage()
        {


            return 0;
        }

        public override string ToString()
        {
            return string.Format($"Life:  {Life}\nName: {Name}\nHit Chance: {HitChance}\n Block: {Block}\nMax Life:{MaxLife}");
        }
    }
}