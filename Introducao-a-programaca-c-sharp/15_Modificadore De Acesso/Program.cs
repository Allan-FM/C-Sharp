using System;

namespace _15_Modificadore_De_Acesso
{
    //public, private, protected, internal
    //public: a *coisa* (membro, metodo, classe) pode ser acessada E alterada fora do escopo de definicao
    //private: a *coisa* SO pode ser acessada e alterada dentro do escopo de definicao
    //protected: a *coisa* SO pode ser acessada e alterada DENTRO do escopo da classe ou das classes filhas
    //internal: a *coisa* SO pode ser acessada e alterada DENTRO do ASSEMBLY em que ela foi definida
    class Character
    {
        protected int damage = 10;
    }
    class Player : Character
    {
        
        public string name;
        public int level;
        public Player()
        {
            damage = 1000;
            name = "Player1";
            level = 1;
        }
        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine($"Nome -> {player.name}");
            Console.WriteLine($"Level -> {player.level}");
            Console.ReadKey();
        }
    }
}
