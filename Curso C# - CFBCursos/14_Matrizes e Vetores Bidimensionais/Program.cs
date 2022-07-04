using System;

namespace _14_Matrizes_e_Vetores_Bidimensionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3,5];
            int[,] arrayBi = new int[2,2] {{10,20}, {24,45}};
            
            numbers[0,0] = 10; numbers[0,1] = 20; numbers[0,2] = 30; numbers[0,3] = 40; numbers[0,4] = 50;
            numbers[1,0] = 15; numbers[1,1] = 25; numbers[1,2] = 35; numbers[1,3] = 45; numbers[1,4] = 55;
            numbers[2,0] = 24; numbers[2,1] = 32; numbers[2,2] = 46; numbers[2,3] = 41; numbers[2,4] = 57;


            Console.WriteLine(numbers[1,4]);

            Console.ReadKey();
        }
    }
}
