using System;
using System.Collections.Generic;
using System.Text;
using TheSharkGame.Monsters;

namespace TheSharkGame
{
    class Game
    {
        Player p1 = new Player();

        Random random = new Random();
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
                        AdEvent();
                        //AdventureTime();
                        break;
                    case 2:
                        p1.PlayerInfo();
                        break;
                    case 3:
                        QuitGame();
                        break;
                }
            } while (run);
        }

        //Intro, ask player for name
        public void StartGame()
        {
            Console.WriteLine("  **********************************" +
                "\n  *                                *" +
                "\n  *   Welcome to The Shark Game!   *" +
                "\n  *               .                * " +
                "\n  *         \\_____)\\_____          *" +
                "\n  *         /--v____ __`<          *" +
                "\n  *                 )/             *" +
                "\n  *                 '              *" +
                "\n  **********************************" +
                "\n  ");
            Console.Write("  Enter your name: ");
            string name = Console.ReadLine();
            p1.Name = name;
            p1.PlayerInfo();
            Console.WriteLine("  You have been looking for a planet to land your spaceship on. " +
                "\n  Finally you find the perfect blue planet! " +
                "\n  You land on this mysterious planet...");
            Enter();
        }

        //Show menu-options
        public void Menu()
        {
            Console.WriteLine("  " +
                "\n  What do you want to do?" +
                "\n  " +
                "\n  1. Go on a adventrue" +
                "\n  2. See your stats" +
                "\n  3. Quit game" +
                "\n  ");
            Console.Write("  ");
        }

        //First step in Adventure, 10% nothing happens.
        public void AdEvent()
        {
            int index = random.Next(1, 10);
            if (index == 1)
            {
                Console.WriteLine("  ----------------------------------" +
                    "\n  " +
                    "\n  You go on a adventrue but nothing happens..." +
                    "\n  " +
                    "\n  ----------------------------------");
            }
            else if (index >= 1)
            {
                Console.WriteLine("  ----------------------------------" +
                    "\n  " +
                    "\n  You go on a adventrue and a Shark appears!!" +
                    "\n  " +
                    "\n  ----------------------------------");
                //Battle();
            }
        }

        public void QuitGame()
        {
            Console.WriteLine("  ----------------------------------" +
                "\n  " +
                "\n  If you end the game, all your progress will be deleted. Do you want to quit?" +
                "\n  " +
                "\n  1. No" +
                "\n  2. Yes");

            bool qRun;
            do {
                Console.WriteLine("  ");
                Console.Write("  ");
                string qInput = Console.ReadLine();
                if (qInput == "1")
                {
                    Console.WriteLine("  ----------------------------------");
                    run = true;
                    qRun = false;
                }
                else if (qInput == "2")
                {
                    Console.WriteLine("  ----------------------------------" +
                        "\n  " +
                        "\n  Thank you for playing! Bye Bye");
                    run = false;
                    qRun = false;
                }
                else
                {
                    Console.WriteLine("  ----------------------------------" +
                        "\n  " +
                        "\n  Please enter your answer");
                    qRun = true;
                }
            } while (qRun == true);
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
