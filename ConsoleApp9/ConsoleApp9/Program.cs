using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = ""; 

                while(player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSOR : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch(player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw !");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You are lose !");
                        }
                        else
                        {
                            Console.WriteLine("You win !");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win !");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw !");
                        }
                        else
                        {
                            Console.WriteLine("You are lose !");
                        }
                        break;
                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You are lose !");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win !");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw !");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again(Y/N) : ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else 
                { 
                    playAgain = false;
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
