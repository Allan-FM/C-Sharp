using System;
using System.IO.Compression;

namespace _11_SWITCH_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;
            Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
            Console.WriteLine("Escolha um meio de transporte -> [a]Aviao | [c]Carro | [o] Onibus");

            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                    tempo = 50;
                    Console.WriteLine($"O tempo da viagem vai ser de {tempo} minutos");
                    break;
                case 'c':
                    tempo = 480;
                    Console.WriteLine($"O tempo da viagem vai ser de {tempo} minutos (8 horas)");
                    break;
                case 'o':
                    tempo = 660;
                    Console.WriteLine($"O tempo da viagem vai ser de {tempo} minutos (11 horas)");
                    break;
                default:
                    Console.WriteLine("Digite um opcao valida ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
