using System;
using System.Data;

namespace _5_Lendo_valores_do_teclado
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int res;
            string nome;

            Console.Write("Digite o primeiro valor -> ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor -> ");
            number2 = int.Parse(Console.ReadLine());
            res = number1 + number2;
            Console.WriteLine($"A soma de {number1} + {number2} = {res}");
            /*
            Console.Write("Digite o primeiro numero -> ");
            nome = Console.ReadLine();
            Console.WriteLine(nome);
            */
            Console.ReadKey();

        }
    }
}
