using System;

namespace _16_Loop_WHILE__Estruturas_de_iteraão
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i++;
            }

            Console.ReadKey();
        }
    }
}
