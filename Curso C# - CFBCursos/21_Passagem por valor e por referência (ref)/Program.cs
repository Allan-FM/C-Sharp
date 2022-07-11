using System;

namespace _21_Passagem_por_valor_e_por_referência
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Dobrar(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }
        static void Dobrar(ref int valor)   
        {
            valor *= 2;
        }
    }
}
