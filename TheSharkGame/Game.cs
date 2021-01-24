using System;
using System.Collections.Generic;
using System.Text;
using TheSharkGame.Monsters;

namespace TheSharkGame
{
    class Game
    {
        Player p1 = new Player();
        bool win = false;
        bool run = true;


        public Game()
        {
            StartGame();

            do
            {
                Menu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //AdventureTime();
                        break;
                    case 2:
                        p1.PlayerInfo();
                        break;
                    case 3:
                        //QuitGame();
                        run = win;
                        break;
                }
            } while (run);


        }

        public void StartGame()
        {
            Console.WriteLine("  **********************************" +
                $"\n  *                                *" +
                $"\n  *   Welcome to The Shark Game!   *" +
                $"\n  *               .                * " +
                $"\n  *         \\_____)\\_____          *" +
                $"\n  *         /--v____ __`<          *" +
                $"\n  *                 )/             *" +
                $"\n  *                 '              *" +
                $"\n  **********************************");
            Console.WriteLine("  ");
            Console.Write("  Enter your name: ");
            string name = Console.ReadLine();
            p1.Name = name;
            p1.PlayerInfo();
            Console.WriteLine("  You have been looking for a planet to land your spaceship on. " +
                $"\n  Finally you find the perfect blue planet! " +
                $"\n  You land on this mysterious planet...");
            Enter();
        }

        public void Menu()
        {
            Console.WriteLine("  " +
                $"\n  What do you want to do?" +
                $"\n  " +
                $"\n  1. Go on a adventrue" +
                $"\n  2. See your stats" +
                $"\n  3. Quit game" +
                $"\n  ");
            Console.Write("  ");
        }


        public void Enter()
        {
            Console.WriteLine("  ");
            Console.Write("  - Press Enter to continue -");
            Console.ReadLine();
            Console.WriteLine("  " +
                "\n  ----------------------------------");
        }



    }
}
