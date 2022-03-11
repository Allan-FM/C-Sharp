using System;

namespace Desafio___Media_Ponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = ReadNumberInput("Insira primeira nota -> ");
            int n2 = ReadNumberInput("Insira segunda nota -> ");
            int n3 = ReadNumberInput("Insira terceira nota -> ");

            float sum = n1 + n2 * 2 + n3 * 3;
            float avg = /*cast*/(float)sum / 6;

            Console.WriteLine($"media com peso (1 , 2 , 3)-> {avg}");
            Console.WriteLine($"Aluno passou -> {avg > 60}");
    
            Console.ReadKey();
        }
        static int ReadNumberInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            try
            {
                return int.Parse(input);
            }
            catch (System.Exception)
            {
                return -1;
            }
        }
    }
}
