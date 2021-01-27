using System;
using System.Collections.Generic;
using System.Text;
using TheSharkGame.Monsters;

namespace TheSharkGame
{
    class Game
    {
        Player p1 = new Player();
        GigantHammerheadShark hammerhead = new GigantHammerheadShark();
        IKEAShark ikea = new IKEAShark();
        LaserShark laze = new LaserShark();
        MagicalWhaleShark magicShark = new MagicalWhaleShark();
        MiniShark mini = new MiniShark();
        List<Sharks> sharkList = new List<Sharks>(); 

        Random random = new Random();
        bool win, lose = false;
        bool run = true;
        int levelUp = 20;

        public Game()
        {
            StartGame();
            AddSharks();
            do
            {
                Menu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AdventureTime();
                        break;
                    case 2:
                        p1.PlayerInfo();
                        break;
                    case 3:
                        QuitGame();
                        break;
                    case 9: //Level-up cheat
                        p1.Exp += 70;
                        p1.LevelUp();
                        break;
                }
                if (p1.Level == 10)
                {
                    Console.WriteLine("Wow! You won against the sharks! Now they respect and love you so you are welcome to stay at their homeplanet anytime!");
                    run = win;
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

        public void AdventureTime()
        {
            int sharkIndex = random.Next(sharkList.Count);
            int index = random.Next(1, 10);
            List<string> sharkAttacks = new List<string>();
            sharkAttacks.Add(sharkList[sharkIndex].FirstAtk);
            sharkAttacks.Add(sharkList[sharkIndex].SecondAtk);
            sharkAttacks.Add(sharkList[sharkIndex].ThirdAtk);

            List<int> attackDmg = new List<int>();
            attackDmg.Add(sharkList[sharkIndex].FirstDmg);
            attackDmg.Add(sharkList[sharkIndex].SecondDmg);
            attackDmg.Add(sharkList[sharkIndex].ThirdDmg);

            if (index == 1)
            {
                Console.WriteLine("  ----------------------------------" +
                    "\n  " +
                    "\n  You go on a adventrue but nothing happens..." +
                    "\n  " +
                    "\n  ----------------------------------");
            }
            else if (index > 1)
            {
                    Console.WriteLine("  ----------------------------------" +
                    "\n  ");
                    Battle(sharkIndex);

                int sharkAtkIndex = random.Next(sharkAttacks.Count);

                Console.WriteLine("  ");
                PGetAttacked(sharkAttacks[sharkAtkIndex], attackDmg[sharkAtkIndex]);
                Console.WriteLine("  " +
                "\n  Your hp are now: " + p1.Hp +
                "\n  " + sharkList[sharkIndex].Name + "hp are: " + sharkList[sharkIndex].Hp);
                Console.WriteLine("  ");
                bool battleOngoing = true;
                while (battleOngoing)
                {
                    
                    PlayerAtkChoice();
                    Console.Write("  ");
                    int atkChoice = Convert.ToInt32(Console.ReadLine());
                    if (atkChoice == 1)
                    {
                        p1.AttackShark(sharkList[sharkIndex].Name);
                        sharkList[sharkIndex].GetAttacked(p1.AtkDmg);

                        if (sharkList[sharkIndex].Hp <= 0)
                        {
                            Console.WriteLine("  The " + sharkList[sharkIndex].Name + " gets scared and swims away.");
                            p1.WinExp(sharkList[sharkIndex].GiveExp);
                            battleOngoing = win;
                        }
                        else if (p1.Hp <= 0)
                        {
                            Console.WriteLine("  Oh no! You lost against the mighty sharks! Start over, bye bye");
                            run = lose;
                        }
                        else
                        {
                            int sharkAtkIndexTwo = random.Next(sharkAttacks.Count);
                            Console.WriteLine("  ");
                            PGetAttacked(sharkAttacks[sharkAtkIndexTwo], attackDmg[sharkAtkIndexTwo]);
                            Console.WriteLine("  " +
                            "\n  Your hp are now: " + p1.Hp +
                            "\n  " + sharkList[sharkIndex].Name + " hp are: " + sharkList[sharkIndex].Hp);
                            Console.WriteLine("  ");
                        }
                    }
                    else if (atkChoice == 2)
                    {
                        int smwRandom = random.Next(1, 2);

                        if (smwRandom == 1)
                        {
                            Console.WriteLine(" " +
                                "\n  The " + sharkList[sharkIndex].Name + " smile and wave back" +
                                "\n  It likes you and give you " + sharkList[sharkIndex].GiveExp + " exp and swim away!");
                            p1.WinExp(sharkList[sharkIndex].GiveExp);
                            battleOngoing = win;
                        }
                        else
                        {
                            Console.WriteLine("  The shark don't see your gesture");
                            continue; 
                        }

                    }
                    else
                    {
                        Console.WriteLine("  ----------------------------------" +
                            "\n  " +
                            "\n  Please enter your answer");
                    }

                }

                if (p1.Exp < levelUp)
                {
                    Console.WriteLine(" " +
                        "\n  ----------------------------------" +
                        "\n  " +
                        "\n  You won against the shark! You gain " + sharkList[sharkIndex].GiveExp + " exp!" +
                        "\n  " +
                        "\n  ----------------------------------");
                    sharkList[sharkIndex].SharkRestore();
                    
                }

                else if (p1.Exp >= levelUp)
                {
                    Console.WriteLine(" " +
                        "\n  ----------------------------------" +
                        "\n  " +
                        "\n  You won against the shark! You gain " + sharkList[sharkIndex].GiveExp + " exp!" +
                        "\n  " +
                        "\n  ----------------------------------");
                    p1.LevelUp();
                    levelUp += 20;
                    foreach (var shark in sharkList)
                    {
                        shark.LevelUpShark();
                    }
                }



            }
        }

        public void Battle(int sharkListI)
        {
            sharkList[sharkListI].SharkAttack();
            
        }

        public void PGetAttacked(string sharkAttack, int attackdmg)
        {
            Console.WriteLine("  " + sharkAttack + " You lose " + attackdmg + " hp.");
            p1.GetAttacked(attackdmg);
        }

        public void AddSharks()
        {
            sharkList.Add(hammerhead);
            sharkList.Add(ikea);
            sharkList.Add(laze);
            sharkList.Add(magicShark);
            sharkList.Add(mini);
        }

        public void PlayerAtkChoice()
        {
            Console.WriteLine(" " +
                "\n  What do you wanna do?" +
                "\n  1. Attack shark (" + p1.AtkDmg + " in damage)" +
                "\n  2. Smile and wave (0 in damage)" +
                "\n " );
        }

        public void SmileAndWave(string sharkname)
        {
            Console.WriteLine("  You smile and wave at the " + sharkname);
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
