using System;

namespace _16_Propriedades__Gettters_e_Setters_
{
    //public, private, protected, internal
    // 1 - private por default
    // 2 - usar getters e/ou setters para expor acesso aos membros da classe
    // 3 - ter poucos metodos pulicos
    class Player
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        private int level;
        public int Level => level;
        
        //auto Property
        public int Money { get; private set; }
        public Player(string name, int level, int money)
        {
            this.name = name;
            this.level = level;
            Money = money;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("P1", 1, 100);
            Console.WriteLine($"Name -> {player.Name}, {player.Level}, {player.Money}");
            player.Name = "New Name";
            Console.WriteLine($"Name -> {player.Name}");
            Console.ReadKey();
        }
    }
}
