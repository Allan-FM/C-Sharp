using System;

namespace _12_Classes_Dados_E_Funcionalidades
{
    class Player
    {
        public string name = "Allan";
        public int level = 1;

        public void Teste()
        {
            Console.WriteLine($"Name -> {name}");
        }
    }
    class Program
    {
        static void Main(string[] args)   
        {
            Player player = new Player();
            Console.WriteLine($"O nome do player e {player.name} e o level- > {player.level}");
            player.level = 100;
            Console.WriteLine($"O level do player agora e -> {player.level}");
            Console.ReadKey();
        }
    }
}
