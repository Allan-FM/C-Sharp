using System;

namespace Desafio___Loja_de_items
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itemOptions = new string[]
            {
                "Pao de Queijo", 
                "Batata-Frita",
                "Red Bull"
            };

            int playerCoinCount = 5;
            string[] playerItems = new string[playerCoinCount];
            int counter = 0;
            PrintLineAndWait("Bem vindo a nossa loja!");
            PrintLineAndWait("Vejo que voce tem muitos coins com voce...");
            PrintLineAndWait("Hmmm... Voce quer dar uma olhada no meu estoque? Sim ou SIM?");
            while(playerCoinCount > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Esse sao nossos items: ");
                for (int i = 0; i < itemOptions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {itemOptions[i]}");
                }
                string item = ReadItem("Digite o numero do item que voce deseja comprar -> ", itemOptions);
                playerItems[counter] = item;
                playerCoinCount--;
                counter++;

                Console.WriteLine();
                PrintLineAndWait($"Voce comprou um {item} por 1 coin! Voce tem mais {playerCoinCount} coins.");
                Console.WriteLine();
            } 
            Console.WriteLine();
            Console.WriteLine("Voce nao tem mais dinheiro! Esse sao seus items: ");
            foreach (var item in playerItems)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static int ReadNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int number;
            if(int.TryParse(input, out number))
            {
                return number;
            }
            return -1;
        }
        static string ReadItem(string message, string[] itemOptions)
        {
            int index = ReadNumber(message);
            index -= 1;
            while(index < 0 || index >= itemOptions.Length)
            {   
                Console.WriteLine("Eu nao conheco esse item. Tente novamente!");
                index = ReadNumber(message);
                index -= 1;
            }
            return itemOptions[index];   
        }
    }
}
