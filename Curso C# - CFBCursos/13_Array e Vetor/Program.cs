using System;

namespace _13_Array_e_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = new int[5];

            numbers1[0] = 1;
            numbers1[1] = 2;
            numbers1[2] = 3;
            numbers1[3] = 4;
            numbers1[4] = 5;
            Console.WriteLine(numbers1[2]);

            int[] numbers2 = new int[] { 10, 2, 4, 5, 6 };
            Console.WriteLine(numbers2[3]);

            string[] myString = new string[] { "Allan", "Felipe" };
            Console.WriteLine(myString[1]);
            Console.ReadKey();
        }
    }
}
