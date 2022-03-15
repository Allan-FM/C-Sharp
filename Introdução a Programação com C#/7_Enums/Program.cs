using System;

namespace _7_Enums
{
    class Program
    {
        //enum (enumeracao)
        enum DifficultyLevel //Difinindo um tipo
        {
            Begginer = 0,
            Normal,
            Expert,

            GodMode
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Seja bem vindo! Escolha o seu nivel de dificuldade.");
            Console.WriteLine($"As opcoes sao: {DifficultyLevel.Begginer}, {DifficultyLevel.Normal} e {DifficultyLevel.Expert}");
            string difficultyLevelString = Console.ReadLine();
            DifficultyLevel difficultyLevel;
            bool success = Enum.TryParse<DifficultyLevel>(difficultyLevelString, out difficultyLevel);
            int enemyPower = 20;
            bool isFirstTimeUser = false;

            if(success)
            {
                switch(difficultyLevel)
            {
                case DifficultyLevel.Begginer:
                    Console.WriteLine("Nivel de dificuldade escolhido -> Iniciante");
                    Console.WriteLine($"Forca dos inimigos: {enemyPower}");
                    break;

                case DifficultyLevel.Normal:
                    Console.WriteLine("Nivel de dificuldade escolhido -> Normal");
                    Console.WriteLine($"Forca dos inimigos: {enemyPower * 2}");
                    break;

                case DifficultyLevel.Expert:
                    if(isFirstTimeUser == true)
                    {
                        Console.WriteLine("Voce nao pode escolher a opcao Expert na primeira vez que esta jogando!");
                    }
                    else
                    {
                        Console.WriteLine("Nivel de dificuldade escolhido -> Expert");
                        Console.WriteLine($"Forca dos inimigos: {enemyPower * 5}");
                    }
                    break;

                default:
                    Console.WriteLine($"Nivel de dificuldade nao encontrado: {difficultyLevel}");
                    break;
                }
            }
            else
            {
                Console.WriteLine($"Valor inespera: {difficultyLevelString}");   
            }
            Console.ReadKey();
        }
    }
}
