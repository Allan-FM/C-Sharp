using System;
using System.Collections.Generic;

namespace Desafio_Loja_De_Items_com_classes
{
    class Item
    {
        public string name;
        public int price;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>()
            {
                new Item
                {
                    name = "Pao de queijo",
                    price = 1,
                },
                new Item
                {
                    name = "Arroz",
                    price = 2,
                },
                new Item
                {
                    name = "Feijao",
                    price = 3,
                }
            };

            int playerCoinCount = 5;
            List<Item> playerItems =  new List<Item>();

            PrintLineAndWait("Bem vindo a nossa loja!");
            PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
            PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");

            while(CanBuyAnyItems(playerCoinCount, items))
            {
                PrintStoreOptions(items);
                playerCoinCount = TryBuyItems(items, playerCoinCount, playerItems);
            }
            Console.WriteLine();
            PrintStoreOptions(items);

            Console.WriteLine();
            Console.ReadKey();
        }
        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static bool CanBuyAnyItems(int playerCoinCount, List<Item> items)
        {
            foreach (var item in items)
            {
               if(playerCoinCount >= item.price)
               {
                   return true;
               }
            }
            return false;
        }
        static void PrintStoreOptions(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("Esse sao nossos items:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: - {items[i].name} - ${items[i].price}");
            }
        }
        static int TryBuyItems(List<Item> itemOptions, int playerCoinCount, List<Item> playerItems)
        {
            Item item = ReadItem("Digite o numero do item que voce deseja comprar -> ", itemOptions);

            if(playerCoinCount >= item.price)
            {
                playerItems.Add(item);
                playerCoinCount -= item.price;
                Console.WriteLine();
                Console.WriteLine($"Voce comprou {item.name} por ${item.price}.");
                Console.WriteLine($"Voce tem ${playerCoinCount} coins.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Esse item custa ${item.price} mas voce so tem ${playerCoinCount} coins");
                Console.WriteLine();
            }
            return playerCoinCount;
        }
        static Item ReadItem(string message, List<Item> itemOptions)
        {
            int index = ReadNumber(message);
            index -= 1;
            while (index < 0 || index >= itemOptions.Count)
            {
                Console.WriteLine("Eu nao conheco esse item! E voce nao sai ate comprar!!!!");
                index = ReadNumber(message);
                index -= 1;
            }
            return itemOptions[index];
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
    }
}
