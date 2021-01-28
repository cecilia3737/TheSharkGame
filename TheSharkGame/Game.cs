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
        List<string> sharkAttacks = new List<string>();
        List<int> attackDmg = new List<int>();

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
                if (p1.Hp <= 0)
                {
                    run = lose;
                }

                if (p1.Level == 10)
                {
                    WinGame();
                    run = win;
                }
            } while (run);
        }

        //Intro, ask player for name
        public void StartGame()
        {
            Console.WriteLine("  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-" +
                "\n  *                                *" +
                "\n  *   Welcome to The Shark Game!   *" +
                "\n  *               .                * " +
                "\n  *         \\_____)\\_____          *" +
                "\n  *         /--v____ __`<          *" +
                "\n  *                 )/             *" +
                "\n  *                 '              *" +
                "\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-" +
                "\n  ");
            Console.Write("  Enter your name: ");
            string name = Console.ReadLine();
            p1.Name = name;
            p1.PlayerInfo();
            Console.WriteLine("  " +
                "\n  You have been looking for a planet to land your spaceship on. " +
                "\n  Finally you find the perfect blue planet! " +
                "\n  You land on this mysterious planet...good thing you brought a towel to a planet with this much water!" +
                "\n  I wonder what will happen?");
            Enter();
        }

        //Show menu-options
        public void Menu()
        {
            Console.WriteLine("  " +
                "\n  What do you want to do?" +
                "\n  " +
                "\n  1. You exit your space ship and dive into the great unknown" +
                "\n  2. See your stats" +
                "\n  3. Quit game" +
                "\n  ");
            Console.Write("  ");
        }

        //If case 1, nothing happens or player gets attacked by shark
        public void AdventureTime()
        {
            int sharkIndex = random.Next(sharkList.Count);
            AddSharkAttacks(sharkIndex);
            bool battleOngoing = true;

            int index = random.Next(1, 10);
            if (index == 1)
            {
                Console.WriteLine("  ----------------------------------" +
                    "\n  " +
                    "\n  You go on a adventure but nothing happens..." +
                    "\n  " +
                    "\n  ----------------------------------");
            }
            else if (index > 1)
            {
                    Console.WriteLine("  ----------------------------------" +
                    "\n  ");
                
                sharkList[sharkIndex].SharkAppears();

                int sharkAtkIndex = random.Next(sharkAttacks.Count);
                PGetAttacked(sharkAttacks[sharkAtkIndex], attackDmg[sharkAtkIndex]);
                BattleShowHp(sharkIndex);
                if (p1.Hp <= 0)
                {
                    battleOngoing = false;
                    p1.Lose();
                }
                else 
                { 
                
                    while (battleOngoing)
                    {
                        PlayerAtkChoice();
                        Console.Write("  ");
                        int atkChoice = Convert.ToInt32(Console.ReadLine());
                        if (atkChoice == 1)
                        {
                                Console.WriteLine("  ----------------------------------");
                                p1.AttackShark(sharkList[sharkIndex].Name);
                                sharkList[sharkIndex].GetAttacked(p1.AtkDmg);
                            BattleShowHp(sharkIndex);
                            Enter();


                            if (sharkList[sharkIndex].Hp <= 0)
                            {
                                Console.WriteLine("  The " + sharkList[sharkIndex].Name + " gets scared and swims away.");
                                p1.WinExp(sharkList[sharkIndex].GiveExp);
                                battleOngoing = win;
                            }

                            else
                            {
                                    int sharkAtkIndexTwo = random.Next(sharkAttacks.Count);
                                    PGetAttacked(sharkAttacks[sharkAtkIndexTwo], attackDmg[sharkAtkIndexTwo]);
                                
                            }

                                if (p1.Hp <= 0)
                                {
                                    p1.Lose();
                                    break;
                                }
                                else
                                {
                                    BattleShowHp(sharkIndex);
                                }

                        }
                        else if (atkChoice == 2)
                        {
                            int smwRandom = random.Next(1, 2);
                            p1.SmileAndWave(sharkList[sharkIndex].Name);
                            Enter();

                            if (smwRandom == 1)
                                     {   
                                            sharkList[sharkIndex].SmileAndWave();
                                            p1.WinExp(sharkList[sharkIndex].GiveExp);
                                            battleOngoing = win;
                                     }
                                     else
                                     {
                                Console.WriteLine("  " +
                                    "\n  The shark don't see your gesture");
                                        continue; 
                                     }

                        }
                        else
                        {
                            Console.WriteLine("  ----------------------------------" +
                                "\n  " +
                                "\n  Oh, that is not a number to chose from...please enter 1,2,3 or why not 9?");
                        }

                    }
                
                }
                Enter();
                if (p1.Hp <= 0)
                {
                    run = lose;
                }

                else 
                {

                        if (p1.Exp < levelUp)
                        {
                            p1.WinBattle(sharkList[sharkIndex].GiveExp);
                            sharkList[sharkIndex].SharkRestore();
                        }

                        else if (p1.Exp >= levelUp)
                        {
                            p1.WinBattle(sharkList[sharkIndex].GiveExp);
                            p1.LevelUp();
                            levelUp += 20;
                            sharkList[sharkIndex].SharkRestore();
                            foreach (var shark in sharkList)
                            {
                                shark.LevelUpShark();
                            }
                        }
                }
            }
            sharkAttacks.Clear();
            attackDmg.Clear();
        }

        //Player get attacked by random shark with random attack
        public void PGetAttacked(string sharkAttack, int attackdmg)
        {
            Console.WriteLine("  " +
                "\n  " + sharkAttack + " You lose " + attackdmg + " hp.");
            p1.GetAttacked(attackdmg);
        }

        public void BattleShowHp(int sharkIndex)
        {
            if (sharkList[sharkIndex].Hp > 0) 
            {
                Console.WriteLine("" +
                    "\n  ----------------------------------");
                p1.ShowHp();
                sharkList[sharkIndex].ShowHp();
            }
            else
            {
                sharkList[sharkIndex].Hp = 0;

                Console.WriteLine("" +
                    "\n  ----------------------------------");
                p1.ShowHp();
                sharkList[sharkIndex].ShowHp();
            }
        }

        public void AddSharks()
        {
            sharkList.Add(hammerhead);
            sharkList.Add(ikea);
            sharkList.Add(laze);
            sharkList.Add(magicShark);
            sharkList.Add(mini);
        }

        public void AddSharkAttacks(int sharkNr)
        {
            sharkAttacks.Add(sharkList[sharkNr].FirstAtk);
            sharkAttacks.Add(sharkList[sharkNr].SecondAtk);
            sharkAttacks.Add(sharkList[sharkNr].ThirdAtk);

            attackDmg.Add(sharkList[sharkNr].FirstDmg);
            attackDmg.Add(sharkList[sharkNr].SecondDmg);
            attackDmg.Add(sharkList[sharkNr].ThirdDmg);
        }

        //Menu for player attack
        public void PlayerAtkChoice()
        {
            Console.WriteLine("  ----------------------------------" +
                "\n  " +
                "\n  What do you want to do?" +
                "\n  " +
                "\n  1. Attack shark (" + p1.AtkDmg + " in damage)" +
                "\n  2. Smile and wave (0 in damage)" +
                "\n  ");
        }

        //Ask player if they want to quit
        public void QuitGame()
        {
            Console.WriteLine("  ----------------------------------" +
                "\n  " +
                "\n  Do you reeeeally want to quit? All your progress will be deleted." +
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
                        "\n  Fine, i don't care...Thank you for playing...I guess this is good bye *sniff sniff*");
                    run = false;
                    qRun = false;
                }
                else
                {
                    Console.WriteLine("  ----------------------------------" +
                        "\n  " +
                        "\n  That did not make any sense...make pick another number");
                    qRun = true;
                }
            } while (qRun == true);
        }

        //End text if player win.
        public void WinGame()
        {
            Console.WriteLine("Wow! You won against the sharks! Now they respect and love you. " +
                        "\n  You are welcome to stay on their home planet anytime!" +
                        "\n  They gift you with a magical trident. You are basically Aquaman now. You are cool." +
                        "" +
                        "" +
                        "  Thank you for playing with the sharks!" +
                        "");
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
