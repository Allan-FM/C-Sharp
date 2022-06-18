using System;

namespace _6_Controle_De_Fluxo__switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo! Escolha o seu nivel de dificuldade.");
            Console.WriteLine("As opcoes sao: Iniciante, Normal e Expert");
            string difficultyLevel = Console.ReadLine();
            int enemyPower = 20;
            bool isFirstTimeUser = false;

            switch(difficultyLevel)
            {
                case "Iniciante":
                    Console.WriteLine("Nivel de dificuldade escolhido -> Iniciante");
                    Console.WriteLine($"Forca dos inimigos -> {enemyPower}");
                    break;

                case "Normal":
                    Console.WriteLine("Nivel de dificuldade escolhido -> Normal");
                    Console.WriteLine($"Forca dos inimigos -> {enemyPower * 2}");
                    break;

                case "Expert":
                    if(isFirstTimeUser)
                    {
                        Console.WriteLine("Voce nao pode escolher a opcao Expert na primeira vez que esta jogando!");
                    }
                    else
                    {
                        Console.WriteLine("Nivel de dificuldade escolhido -> Expert");
                        Console.WriteLine($"Forca dos inimigos -> {enemyPower * 5}");
                    }
                    break;

                default:
                    Console.WriteLine($"Nivel de dificuldade nao encontrado: {difficultyLevel}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
