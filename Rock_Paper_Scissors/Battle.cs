using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Battle
    {
        public static void AreaForBattle(int playerWeapon, WeaponType aiWeapon)
        {
            Console.WriteLine("             YOUR CHOICE:                                             AI CHOICE:");
            if (playerWeapon == 1) Console.WriteLine("");
        }

        public static void StartBattle() 
        { 
            Console.Clear();
            Console.WriteLine("                                             CHOOSE YOUR WEAPON!\n");
            Console.WriteLine("ROCK wins against SCISSORS                 PAPER wins against ROCK                     SCISSORS wins against PAPER\n");
            Console.WriteLine("Write <ROCK> or <PAPER> or <SCISSORS> ");

            string playerInput;
            WeaponType computerChoice;
            int playerChoice = 0;
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
            computerChoice = (WeaponType)random.Next(1,4);
            AreaForBattle(playerChoice, computerChoice);


        }
    }
}
