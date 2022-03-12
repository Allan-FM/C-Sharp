using System;

namespace _5_Controle_De_Fluxo__if_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opcoes -> Iniciante, Normal ou Expert.");
            string difficultyLevel = Console.ReadLine();
            //iniciante 1x enemyPower, normal 2x enemyPower e expert 5x enemyPower
            int enemyPower = 20;    
            if(difficultyLevel == "Iniciante")
            {
                Console.WriteLine("Voce escolheu a opcao iniciante");
                Console.WriteLine($"Forca do inimigo -> {enemyPower}");
            }
            else if(difficultyLevel == "Normal")
            {
                Console.WriteLine("Voce escolheu a opcao iniciante");
                Console.WriteLine($"Forca do inimigo -> {enemyPower * 2}");
            }
            else if(difficultyLevel == "Expert")
            {
                Console.WriteLine("Voce escolheu a opcao iniciante");
                Console.WriteLine($"Forca do inimigo -> {enemyPower * 5}");
            }
            else
            {
                Console.WriteLine("Opcao nao encontrada! Escolha: Iniciante, Normal ou Expert");
            }

            Console.ReadKey();
        }
    }
}
