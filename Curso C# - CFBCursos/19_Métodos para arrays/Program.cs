using System;

namespace _19_Métodos_para_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 23, 45, 55, 66 }, { 77, 88, 99, 11, 22 } };

            Random random = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50);
            }

            Console.WriteLine("Elemento do Vetor 1: ");
            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }

            //BinarySearch
            Console.WriteLine("BinarySearch");
            int procurando = 33;
            int position = Array.BinarySearch(vetor1, procurando);
            Console.WriteLine($"Valor {procurando} esta na posicao {position}");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            //Copy
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach (var item in vetor2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine();

            //CopyTo
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach (var item in vetor3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine();

            //GetLongLength
            Console.WriteLine("GetLongLength");
            long elementsLongVetor = vetor1.GetLongLength(0);
            Console.WriteLine($"Quantidade de elementos -> {elementsLongVetor}");
            Console.WriteLine("-------------------");
            Console.WriteLine();

        }
    }
}
