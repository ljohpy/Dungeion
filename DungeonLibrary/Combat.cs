using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //This is NOT a datatype class, so it won't have
        //fields, properties, or constructors. It will
        //simply serve as a warehouse for a variety of
        //methods related to combat.

        //Let's create a method to handle a one-sided attack
        public static void DoAttack(Character attacker, Character defender)
        {
          
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            //Nothing is TRULY random is programming, but suspending
            //the code execution briefly may help simulate "randomness".
            //We can Thread.Sleep() for this, which is located in the
            //System.Threading namespace.

            Thread.Sleep(30);

            
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                
                int damageDealt = attacker.CalcDamage();

                
                defender.Life -= damageDealt;

                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDealt);

                Console.ResetColor();
            }
            
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }

        
        public static void DoBattle(Player player, Monster monster)
        {
            
            DoAttack(player, monster);

            
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }

    }
}
