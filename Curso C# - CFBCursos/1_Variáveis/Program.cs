using System;

namespace Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            char letras = 'c';
            float valor = 4.3f;

            string nome = "Allan";

            var auxiliar = 21;

            Console.WriteLine($"{num} - {letras} - {valor} - {nome} - {auxiliar}");

            Console.ReadKey();
        }
    }
}
