using System;

namespace _9_Controle_De_Fluxo__For_and__While_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itemList = new string[] { "espada", "escudo", "capacete" };

            for (int i = 0; i < itemList.Length; i++)
            {
                string items = itemList[i];
                Console.WriteLine($"Items: {items}");
            }

            Console.WriteLine();

            foreach (string items in itemList)
            {
                Console.WriteLine($"Items: {items}");
            }

            Console.WriteLine();

            //tirar 1 hitpoint por segundo enquanto estiver com poison e vivo
            int healf = 10;
            bool isPoisoned = true;
            while (isPoisoned == true && healf > 0)
            {
                healf -= 1;
                Console.WriteLine($"Voce tomou dano -> Vida: {healf}");
                Console.ReadKey();
            }
            Console.WriteLine("Voce nao tem mais vida!");

            
            Console.ReadKey();
        }

    }
}
