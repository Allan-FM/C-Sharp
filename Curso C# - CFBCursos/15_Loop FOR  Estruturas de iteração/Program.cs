using System;

namespace _15_Loop_FOR__Estruturas_de_iteração
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int[] arr = new int[] { 10, 2, 4, 5, 6, 7, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
