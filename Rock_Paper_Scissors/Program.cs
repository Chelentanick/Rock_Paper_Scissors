using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        public static void Stat(string name, int age, int rounds, int wins)
        {
            Console.WriteLine("________________________YOUR  DATA_______________________");
            Console.WriteLine("_________________________________________________________\n");

            Console.WriteLine($"| Name: {name} | | Age: {age} | | Rounds: {rounds} | | Wins: {wins} |");
            Console.WriteLine("_________________________________________________________\n\n");
            
            
        }
        public static void PlayerDecision(string name, ref int playerChoice, ref WeaponType computerChoice,ref int playerWins)
        {
            Console.WriteLine("Do you want to start battle ? (yes/no)");
            string decision = Console.ReadLine();
            decision.ToLower();
            if (decision == "no")
            {
                Console.WriteLine($"Have a good day,{name} Bye!");
                return;
              
            }
            else if (decision == "yes" || decision == "yed" || decision == "yea" || decision == "yee" || decision == "yse")
            {
               Battle.StartBattle(ref playerChoice,ref computerChoice, ref playerWins);
            }
            else Console.WriteLine("INVALID VALUE");
        }
        static void Main(string[] args)

        {
            
                int playerChoice = 0;
                WeaponType computerChoice = 0;
                string playerName = "";
                int playerAge = 0;
                int playerRounds = 0;
                int playerWins = 0;
                SayHello.SayHelloToPlayer(ref playerName, ref playerAge);
                if (playerAge <= 12)
                {
                    Console.WriteLine("This game for older players. Have a nice day!");
                    return;
                }
                Stat(playerName, playerAge, playerRounds, playerWins);
            while (true) { 
                PlayerDecision(playerName, ref playerChoice, ref computerChoice, ref playerWins);
              

                Console.Clear();
                playerRounds++;
                Stat(playerName, playerAge, playerRounds, playerWins);
                Console.WriteLine("Do You want play again? (yes/no)");
                string playAgainInput = Console.ReadLine(); 

                if(playAgainInput !="yes") { break; }


            }
        }
    }
}
