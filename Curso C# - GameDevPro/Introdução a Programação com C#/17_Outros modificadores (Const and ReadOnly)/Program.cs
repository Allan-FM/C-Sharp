using System;

namespace _17_Outros_modificadores__Const_and_ReadOnly_
{
    //Const e ReadOnly
    // Readonly somente leitura e em membros (variaveis)
    // Const mesma coisa porem temque inicializar a variavel
    class Item
    {
        public readonly string Name;
        public readonly int Price;

        public const int minItemPrice = 2;

        public Item(int price, string name)
        {
            if(price > minItemPrice)
            {
                Price = price;
            }
            else
            {
                Price = minItemPrice;
            }
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
