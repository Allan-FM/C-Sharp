using System;

namespace _8_Desafio_ChooseYourGear
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLineAndWait("Um apocalipse zumbi acabou de acontecer do nada na sua cidade");
            PrintLineAndWait("Voce comeca a correr e pega tudo que ve pela frente...");
            string[] inventoryItems = new string[3];

            string[] choices1 =  new string[] {"PANELA", "TRAVESSEIRO"};
            string itemChoice1 = ReadItemOption(choices1);
            if(itemChoice1 != "")
            {
                inventoryItems[0] = itemChoice1;
            }
            else
            {
                Console.WriteLine("Erro de INPUT!");
            }

            Console.WriteLine();
            string[] choices2 = new string[] {"ARMA", "GAME BOY"};
            string itemChoice2 = ReadItemOption(choices2);
            if(itemChoice2 != "")
            {
                inventoryItems[1] = itemChoice2;
            }
            else
            {
                Console.WriteLine("Erro de INPUT!");
            }
            
            Console.WriteLine();
            string[] choices3 = new string[] { "CAMISA", "BARRA DE CHOCOLATE" };
            string itemChoice3 = ReadItemOption(choices3);
            if (itemChoice3 != "")
            {
                inventoryItems[2] = itemChoice3;
            }
            else
            {
                Console.WriteLine("Erro de INPUT!");
            }

            Console.WriteLine($"Suas escolhas foram: {inventoryItems[0]}, {inventoryItems[1]} e {inventoryItems[2]}");

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
            if (index >= 0 && index < choices.Length)
            {
                return choices[index];
            }
            return "";
        }
    }
}
