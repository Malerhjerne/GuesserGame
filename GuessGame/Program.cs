using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    // So I Misunderstood the Task and Instead of Names, You have to guees a Number --- 
    class Program
    {
        const int MaxTrials = 10;
        int aOfTryes;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "GuessGame";
            Console.WriteLine(Console.Title);
           
            
            Program program = new Program();
            program.Intro();
        }

        public void Intro()
        {
            Console.WriteLine("Welcome" + "\n" + "Do you want to try this awesome game?" + "\n" + "(y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                GameLogic();
            }

            else if (input == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Intro();
            }
        }

        // Game Logic Method (main Method)
        public void GameLogic()
        {
          
            Console.WriteLine("Try and guess a number between 0 - 20" + "\n" + "You have 10 attempts to get it wright");

            var random = new Random();
            int wrightNumber = random.Next(0, 20);

            
            for (int i = 0; i < 10; i++)
                {
                try                   
                {
                Console.WriteLine("Player tryes : " + (aOfTryes + 1) + "/" + MaxTrials);
                string stringInput = Console.ReadLine();
                int input = Convert.ToInt16(stringInput);

            if (input == wrightNumber)
                    {
                        WinGame();
                    }

            else
            {
                       
                Console.WriteLine("Sorry you dint guess the wright Number");
                aOfTryes++;
                Losegame();
                    }

                }
                catch
                {
                    Console.WriteLine("wrong Input");
                    i -= i;
                }
            }
          
        }
        // Methods For Different Game Situations

        public void Losegame()
        {
            if (aOfTryes == MaxTrials)
            {
                Console.WriteLine("try again");
                aOfTryes = 0;
                Intro();
            }
        }

        public void WinGame()
        {
            Console.WriteLine("You guessed the wright number (:-) ");
            aOfTryes++;
            Console.WriteLine("You used:" + " " + aOfTryes +" " +"tryes!");
            WinSpeech();
            aOfTryes = 0;
            Intro();
        }

        public void WinSpeech()
        {
            if (aOfTryes== 1) {
                Console.WriteLine("WOW NICE!");
            }

            else if (aOfTryes <= 5)
            {
                Console.WriteLine("That was quick");

                }
            else
            {
                Console.WriteLine("Atleast you got it wright");
            }

            }
        }

    }



