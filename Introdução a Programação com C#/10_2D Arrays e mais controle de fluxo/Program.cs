using System;

namespace _10_2D_Arrays_e_mais_controle_de_fluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLineAndWait("Um apocalipse zumbi acabou de acontecer do nada na sua cidade");
            PrintLineAndWait("Voce comeca a correr e pega tudo que ve pela frente...");

            string[] choices1 = new string[] {"PANELA", "TRAVESSEIRO"};
            string[] choices2 = new string[] {"ARMA", "GAME BOY"};
            string[] choices3 = new string[] {"CAMISA", "BARRA DE CHOCOLATE"};

            string[][] allChoices = new string[][]
            {
                choices1, choices2, choices3
            };
            
            string[] inventoryItems = new string[3];
            for(int i = 0; i < inventoryItems.Length; i++)
            {
                string[] currentChoices = allChoices[i];
                string itemChoice = ReadItemOption(currentChoices);
                if(itemChoice != "")
                {
                    inventoryItems[i] = itemChoice;
                }
                else
                {
                    Console.WriteLine("Erro de input!");
                }
            }
            

            Console.Write("Suas escolhas foram: ");
            foreach (string item in inventoryItems)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadKey();
        }

        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static int ReadNumberInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return -1;
            }
        }

        static string ReadItemOption(string[] choices)
        {
            PrintLineAndWait($"Voce se depara com um {choices[0]} e um {choices[1]}");
            int index = ReadNumberInput($"Digite 1 para pegar o {choices[0]} e 2 para pegar o {choices[1]}");
            index -= 1;
            while(index < 0 || index >= choices.Length)
            {
                Console.WriteLine("ERRO: Por favor digite um input valido!");
                index = ReadNumberInput($"Digite 1 para pegar o {choices[0]} e 2 para pegar o {choices[1]}");
                index -= 1;
            }
            return choices[index];
        }
    }
}
