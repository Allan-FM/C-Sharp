using System;

namespace _17_Loop_DO_WHILE__Estruturas_de_iteração
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha ="123";
            string senhaDoUsuario;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhaDoUsuario = Console.ReadLine();

            } while (senha != senhaDoUsuario);

            Console.WriteLine("Senha correta!");
            Console.ReadKey();
        }
    }
}
