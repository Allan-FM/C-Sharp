using System;

namespace _1_ErroNoCodigo
{
    struct Player
    {
        public int Coins;
        public void ExpendCoins()
        {
            Coins--;
        }
    }
    struct UI
    {
        public Player Player;
        public void ShowCoins()
        {
            Console.WriteLine($"Voce tem {Player.Coins} coins");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player
            {
                Coins = 10
            };
            UI ui = new UI
            {
                Player = player
            };
            ui.ShowCoins();
            Console.WriteLine();
            while (player.Coins > 0)
            {
                Console.WriteLine("Aperte qualquer tecla para gastar os coins!");
                Console.ReadKey();
                Console.WriteLine();
                player.ExpendCoins();
                ui.ShowCoins();
            }
            Console.WriteLine("\n\n-------FIM DO PROGRAMA-------------");
            Console.ReadKey();
        }
    }
}
