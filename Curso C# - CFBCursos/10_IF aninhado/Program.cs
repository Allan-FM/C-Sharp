using System;

namespace _10_IF_aninhado
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            float res;
            Console.Write("Digite a sua primeira nota -> ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a sua segunda nota -> ");
            number2 = int.Parse(Console.ReadLine());
            res = ((float)number1 + (float)number2) / 2;
            Console.WriteLine($"Sua nota -> {res}");
            if(res >= 7)
            {
                if(res >= 9)
                {
                    Console.WriteLine("Aprovado com louvor");
                }
                else
                {
                    Console.WriteLine("Aprovado!");
                }
            }
            else
            {
                if(res >= 4)
                {
                    Console.WriteLine("Recuperacao!");
                }
                else
                {   
                    Console.WriteLine("Reprovado!");    
                }
            }

            Console.ReadKey();
        }
    }
}
