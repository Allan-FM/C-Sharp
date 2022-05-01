using System;

namespace _13_Objetos_Construtores_e_static
{
    class Player
    {
        public string name = "Allan";
        public int level = 1;
        public static int initialLevel = 10;
        public void Teste()
        {
            name = "Player1";
            level = 2;
        }
        public static void MyStaticFunction()
        {
            initialLevel = 100;
            //name ->  nao pode ser usada pois nao e static
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();

            Console.WriteLine($"Nome do player -> {p1.name}");
            Console.WriteLine($"Level do player -> {p1.level}");

            Console.WriteLine();
            p1.Teste();
            Console.WriteLine();

            Console.WriteLine($"Nome do player -> {p1.name}");
            Console.WriteLine($"Level do player -> {p1.level}");
            
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine($"Level inicial -> {Player.initialLevel}");
            Player.MyStaticFunction();
            Console.WriteLine($"Level inicial -> {Player.initialLevel}");
            

            Console.ReadKey();
        }
    }
}
