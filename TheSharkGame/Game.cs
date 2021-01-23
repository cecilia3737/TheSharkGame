using System;
using System.Collections.Generic;
using System.Text;
using TheSharkGame.Monsters;

namespace TheSharkGame
{
    class Game
    {
        Player p1 = new Player();

        public Game()
        {
            StartGame();

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
