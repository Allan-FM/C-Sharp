using System;
namespace _8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                -22, 2, 1
            };

            Console.WriteLine(numbers[1]);

            //bounds check
            int i = 5;
            Console.WriteLine($"Tamanho do Array -> {numbers.Length}");
            if(i >= 0 && i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
            }
            else
            {
                Console.WriteLine("indice fora do range do array!");
            }
            Console.ReadKey();
        }
    }
}
