using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taş_Kağıt_Makas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taş-kağıt-makas
            //ctrl+h change all the occurance
            //kullanıcı seçenek girsin pc rastgele seçsin
            // kullanıcı q ile çıkabilsin
            //sonunda skorlar tutulsun
            //oyunu geliştirelim. yapılan hamleler gösterilsin ve skor sayılsın
            //3 olan kazansın 
            Game();
            Console.ReadLine();
        }

        private static void Game()
        {
            Random random = new Random();
            string[] movements = { "rock", "papper", "scissors" };
            string movement = "";
            string pcmovement = "";
            int winner_pc = 0;
            int winner_player = 0;
            do
            {
                Console.WriteLine("Please make a movement: ");
                movement = Console.ReadLine();
                int index = random.Next(0, movements.Length); //0-3 arasındaki hareketi üret demek
                pcmovement = movements[index];
                if(movement == "q")
                {
                    Console.WriteLine("You end this game. Good Bye!");
                }
                else
                {
                    Console.WriteLine(movement + " - " + pcmovement);
                }
                if (movement == "rock" && pcmovement == "scissors") 
                { 
                    winner_player++;
                }
                if (movement == "rock" && pcmovement == "papper")
                {
                    winner_pc++;
                }
                if (movement == "papper" && pcmovement == "scissors")
                {
                    winner_pc++;
                }
                if (movement == "papper" && pcmovement == "rock")
                {
                    winner_player++;
                }
                if (movement == "scissors" && pcmovement == "rock")
                {
                    winner_pc++;
                }
                if (movement == "scissors" && pcmovement == "papper")
                {
                    winner_player++;
                }
                if (movement != "q")
                {
                    Console.WriteLine(winner_player + " - " + winner_pc);
                }
                if (winner_player == 3 || winner_pc == 3)
                {
                    break;
                }

            }
            while (movement != "q");
          
            if(winner_pc > winner_player)
            {
                Console.WriteLine("Winner is PC.");
            }
            else
            {
                Console.WriteLine("Winner is YOU. Good game!");
            }
        }
    }
}
