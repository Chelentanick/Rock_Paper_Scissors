using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Battle
    {
        public static void AreaForBattle(int playerWeapon, WeaponType aiWeapon)
        {
            Console.WriteLine("    YOUR CHOICE:");
            if (playerWeapon == 1) Console.Write("░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░█████████░░░░\r\n░░░░░██░░███░░███░░\r\n░░░██░▒▒░░░░░░░░██░\r\n░░██░▒▒░░░░░░░░░░█░\r\n░░█░░░░░░░░░░░▒▒▒░█\r\n░░█░░░░░░░░░░░░░▒░█\r\n░░█████░░░░░░░█████\r\n░░░░█████████████░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n");
            else if (playerWeapon == 2) Console.Write("░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░████████████░░░\r\n░░░█░░░░░░░░░░░█░░░\r\n░░░█░───░░░────█░░░\r\n░░░█░░░░░░░░░░░█░░░\r\n░░░█░░────────░░█░░\r\n░░░█░░░░░░░░░░░░█░░\r\n░░░█░░─────────░█░░\r\n░░░██░░░░░░░░░░░█░░\r\n░░░░█░░░───────░██░\r\n░░░░██████████████░\r\n");
            else if (playerWeapon == 3) Console.Write("░░░░░░░░░░░░░░░░░░░\r\n░░░░░███░░░████░░░░\r\n░░░░█░░░█░█░░░░█░░░\r\n░░░░█░░██░█░░░██░░░\r\n░░░░░██████████░░░░\r\n░░░░░░░░███░░░░░░░░\r\n░░░░░░░████░░░░░░░░\r\n░░░░░░██░██░░░░░░░░\r\n░░░░░░██░██░░░░░░░░\r\n░░░░░░██░██░░░░░░░░\r\n░░░░░██░░██░░░░░░░░\r\n░░░░░█░░░█░░░░░░░░░\r\n░░░░░█░░░█░░░░░░░░░\r\n");
            Console.WriteLine("\n\n\n\n AI CHOICE:");
            if (aiWeapon == WeaponType.rock) Console.WriteLine("░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░█████████░░░░\r\n░░░░░██░░███░░███░░\r\n░░░██░▒▒░░░░░░░░██░\r\n░░██░▒▒░░░░░░░░░░█░\r\n░░█░░░░░░░░░░░▒▒▒░█\r\n░░█░░░░░░░░░░░░░▒░█\r\n░░█████░░░░░░░█████\r\n░░░░█████████████░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n");
            else if (aiWeapon == WeaponType.paper) Console.WriteLine("░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░\r\n░░░░████████████░░░\r\n░░░█░░░░░░░░░░░█░░░\r\n░░░█░───░░░────█░░░\r\n░░░█░░░░░░░░░░░█░░░\r\n░░░█░░────────░░█░░\r\n░░░█░░░░░░░░░░░░█░░\r\n░░░█░░─────────░█░░\r\n░░░██░░░░░░░░░░░█░░\r\n░░░░█░░░───────░██░\r\n░░░░██████████████░\r\n");
            else if (aiWeapon == WeaponType.scissors) Console.WriteLine("░░░░░░░░░░░░░░░░░░░\r\n░░░░░███░░░████░░░░\r\n░░░░█░░░█░█░░░░█░░░\r\n░░░░█░░██░█░░░██░░░\r\n░░░░░██████████░░░░\r\n░░░░░░░░███░░░░░░░░\r\n░░░░░░░████░░░░░░░░\r\n░░░░░░██░██░░░░░░░░\r\n░░░░░░██░██░░░░░░░░\r\n░░░░░░██░██░░░░░░░░\r\n░░░░░██░░██░░░░░░░░\r\n░░░░░█░░░█░░░░░░░░░\r\n░░░░░█░░░█░░░░░░░░░\r\n");
        }

        public static void StartBattle(ref int playerChoice, ref WeaponType computerChoice, ref int playerWins)
        {
          int playerScore = 0;
            int aiWins = 0;

            for (int round = 1; round <= 3; round++)
            {
                Console.Clear();
                Console.WriteLine("                                             CHOOSE YOUR WEAPON!\n");
                Console.WriteLine("ROCK wins against SCISSORS                 PAPER wins against ROCK                     SCISSORS wins against PAPER\n");
                Console.WriteLine("Write <ROCK> or <PAPER> or <SCISSORS> ");
                playerChoice = 0;
                string playerInput;

                while (playerChoice == 0)
                {
                    playerInput = Console.ReadLine().ToLower();

                    if (playerInput == "rock")
                    {
                        playerChoice = (int)WeaponType.rock;

                    }

                    else if (playerInput == "paper")
                    {
                        playerChoice = (int)WeaponType.paper;

                    }
                    else if (playerInput == "scissors")
                    {
                        playerChoice = (int)(WeaponType.scissors);

                    }

                    else Console.WriteLine("INVALID VALUE");
                }
                Console.Clear();

                Random random = new Random();
                computerChoice = (WeaponType)random.Next(1, 4);
                AreaForBattle(playerChoice, computerChoice);
                if (playerChoice == (int)computerChoice)
                {
                    Console.WriteLine("IT`S A TIE!");

                }
                else if ((playerChoice == 1 && computerChoice == WeaponType.scissors) ||
                         (playerChoice == 2 && computerChoice == WeaponType.rock) ||
                         (playerChoice == 3 && computerChoice == WeaponType.paper))
                {
                    Console.WriteLine("YOU WIN!");

                    playerScore++;

                }
                else
                {
                    Console.WriteLine("AI WIN!");
                    aiWins++;
                }


                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("                     \nGAME OVER");
            if (playerScore > aiWins)
            {
                Console.WriteLine("You win the game!");
                playerWins++;

            }
            else if (playerScore < aiWins) { }
                Console.WriteLine("Computer wins the game!");
            else
                Console.WriteLine("It's a tie game!");

            Console.ReadLine();
        }
    }
}
