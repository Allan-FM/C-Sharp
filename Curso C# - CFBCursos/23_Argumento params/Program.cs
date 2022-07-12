using System;

namespace _23_Argumento_params
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Soma();
            Soma(12);
            Soma(10,7);

            Console.ReadKey();
        }
        static void Soma(params int[] paransNumbers)
        {
            int res = 0;
            if(paransNumbers.Length < 1)
            {
                Console.WriteLine("Nao existem valores a serem somados!");
            }
            else if(paransNumbers.Length < 2)   
            {
                Console.WriteLine($"Valores insuficiente para SOMA: {paransNumbers[0]}");
            }
            else
            {
                for (int i = 0; i < paransNumbers.Length; i++)
                {
                    res += paransNumbers[i];
                }
                Console.WriteLine($"A soma dos valores eh {res}");
            }
        }
    }
}
