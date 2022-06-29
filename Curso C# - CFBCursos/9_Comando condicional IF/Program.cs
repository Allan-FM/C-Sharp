using System;

namespace _9_Comando_condicional_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;
            Console.Write("Digite a sua media final -> ");
            nota = int.Parse(Console.ReadLine());
            if(nota >= 60)
            {
                Console.WriteLine($"Aprovado! -> Nota: {nota}");
            }
            else
            {
                Console.WriteLine($"Reprovado! -> Nota: {nota}");
            }
            Console.ReadKey();
        }
    }
}
