using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {
            Console.Title = "The Chronical Monsters";
            Console.WriteLine("Welcome to this crazy world....Are you afraid?");

            int score = 0;

            Weapon hammer = new Weapon(10, 90, "Hammer", 8, false, WeaponType.Hammer);

            Player player = new Player("Wicked Witch", 65, 15, 60, 60, Race.Witch, hammer);

            bool quit = false;//main loop

            do
            {
                Console.WriteLine(GetRoom());


                Demon demon = new Demon("Creeper", 35, 60, 40, 10, 15, 3, "Eyes shining bright through the dark night", true);

                Unicorn unicorn = new Unicorn("Starlight", 50, 75, 35, 10, 10, 20, "Don't be fooled by my brightness", true);

                Vampire vampire = new Vampire("Drusilla", 75, 75, 40, 20, 10, 35, "High and mighty");

                Zombie zombie = new Zombie("Lurkers", 60, 60, 35, 15, 5, 20, "Scary but inncocent", 10, 8);

               

                Monster[] monsters = { demon, unicorn, vampire, zombie };

                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.WriteLine("\nIn this room you encounter: " + monster.Name);


                bool exit = false;//inner loop
                do
                {
                    //Display the Menu
                    Console.WriteLine("Please make a selection:\n" +
                        "A. Attack\n" +
                        "B. Run Away\n" +
                        "C. Character Info\n" +
                        "D. Monster Info\n" +
                        "E. Exit");

                    //store users input
                    ConsoleKey choice = Console.ReadKey(true).Key;//Executes on key press

                    switch (choice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);

                            if(monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You killed {0}", monster.Name);
                                Console.ResetColor();
                                score++;
                                exit = true;

                            }
                            Console.WriteLine("Attack");
                            //after combat, if we win, set reload = true
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            exit = true;
                            break;

                        case ConsoleKey.C:
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated " + score);
                            
                            break;

                        case ConsoleKey.D:

                            Console.Clear();
                            Console.WriteLine(monster);
                            
                            break;

                        case ConsoleKey.E:
                        case ConsoleKey.X:

                            Console.Clear();
                            Console.WriteLine("Thank you for playing!");
                            exit = true;
                            quit = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been defeated by {0}.", monster.Name);
                        exit = true;
                    }

                } while (!exit && !quit);//end inner loop
                Console.WriteLine();


            } while (!quit);//end main loop





            


        }//end Main()

        //Create Room Descriptions
        

        private static string GetRoom()
        {
            string[] roomDescription =
         {
            "Dark Red Room ",
            "Muddy Room",
            "Yellow Room",
            "Strobe Light Room"
            
            };//End Room Descriptions

            Random rand = new Random();

            int indexNbr = rand.Next(roomDescription.Length);

            string room = roomDescription[indexNbr];

            return room;
        }//end GetRoom



    }//end class
}//end namespace

