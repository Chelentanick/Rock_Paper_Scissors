using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        public static void Stat(string name, int age, int rounds, int wins)
        {
            Console.WriteLine("________________________YOUR  DATA_______________________");
            Console.WriteLine("_________________________________________________________\n");

            Console.WriteLine($"| Name: {name} | | Age: {age} | | Rounds: {rounds} | | Wins: {wins} |");
            Console.WriteLine("_________________________________________________________");
            
        }
        static void Main(string[] args)

        {
            
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






        }
    }
}
