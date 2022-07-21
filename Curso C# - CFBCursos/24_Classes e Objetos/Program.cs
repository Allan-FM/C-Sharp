using System;

namespace _24_Classes_e_Objetos
{
    class Player
    {
        public int energia = 100;
        public bool vida = true;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine($"Energia do player {player.energia}");
            Console.ReadKey();
        }
    }
}
