using System;

namespace _14_Construtores_E_Inicializadores
{
    class Player
    {
        public Player()
        {
            name = "Player1";
            level = 5;
            Console.WriteLine("Metodo construtor!");
        }
        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;   
        }
        public string name = "Player1";
        public int level = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();//Construir um objeto
            Player p2 = new Player("Player2", 10);

            //Initializers
            Player p3 = new Player()
            {
                name = "Player3",
                level = 15,
            };

            Console.WriteLine($"{p1.name} - {p1.level}");
            Console.WriteLine($"{p2.name} - {p2.level}");
            Console.WriteLine($"{p3.name} - {p3.level}");

            Console.ReadKey();
        }
    }
}
