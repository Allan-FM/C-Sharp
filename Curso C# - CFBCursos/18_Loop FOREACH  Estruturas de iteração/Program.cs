using System;

namespace _18_Loop_FOREACH__Estruturas_de_iteração
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {11, 23, 45};

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
