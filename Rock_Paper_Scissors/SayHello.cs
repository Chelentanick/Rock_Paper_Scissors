using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class SayHello
    {
        public static void SayHelloToPlayer(ref string name, ref int age)
        {
            Console.WriteLine("\r\n███████████████████████████████████████████████████████████████████▀█████████████████████\r\n█▄─█▀▀▀█─▄█▄─▄▄─█▄─▄███─▄▄▄─█─▄▄─█▄─▀█▀─▄█▄─▄▄─███─▄─▄─█─▄▄─███─▄▄▄▄██▀▄─██▄─▀█▀─▄█▄─▄▄─█\r\n██─█─█─█─███─▄█▀██─██▀█─███▀█─██─██─█▄█─███─▄█▀█████─███─██─███─██▄─██─▀─███─█▄█─███─▄█▀█\r\n▀▀▄▄▄▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▀▀▄▄▄▀▀▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀\r\n███████████████████████████████████████████████████████████████████████████████████████████████████████\r\n█▄─▄▄▀█─▄▄─█─▄▄▄─█▄─█─▄███▄─▄▄─██▀▄─██▄─▄▄─█▄─▄▄─█▄─▄▄▀███─▄▄▄▄█─▄▄▄─█▄─▄█─▄▄▄▄█─▄▄▄▄█─▄▄─█▄─▄▄▀█─▄▄▄▄█\r\n██─▄─▄█─██─█─███▀██─▄▀█████─▄▄▄██─▀─███─▄▄▄██─▄█▀██─▄─▄███▄▄▄▄─█─███▀██─██▄▄▄▄─█▄▄▄▄─█─██─██─▄─▄█▄▄▄▄─█\r\n▀▄▄▀▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀\n\n\n\n");
            do
            {
                Console.WriteLine("Write your name:");

                name = Console.ReadLine();
                Console.WriteLine("Write your age:");
                string ageString = Console.ReadLine();
                if (int.TryParse(ageString, out age))
                {
                }
                else Console.WriteLine("INVALID VALUE\n");
                if (string.IsNullOrWhiteSpace(name) || age == 0)
                {
                    Console.WriteLine("INVALID VALUE");
                    Console.ReadLine();
                }
                else break;
                ;
                Console.Clear();
            } while (true);


        }
    }
}
