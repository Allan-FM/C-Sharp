using System;

namespace _3_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //SintaxeFOREACH();

            //SintaxFOR();
            //SintaxDoWhile();
            //SintaxWhile();
            //PrintLoop(1);
            Console.ReadKey();
        }

        private static void SintaxeFOREACH()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void SintaxeFOR()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void SintaxeDoWhile()
        {
            int number = 0;
            do
            {
                if (number == 6)
                {
                    break;
                }
                Console.WriteLine(number);
                number++;
            } while (number <= 10);
        }

        private static void SintaxeWhile()
        {
            int number = 0;
            while (number <= 10)
            {
                if (number == 6)
                {
                    number++;
                    break;
                }
                Console.WriteLine(number);
                number++;
            }
        }

        //Funcao recursiva
        static void PrintLoop(int a)
        {
            Console.WriteLine(a);
            if (a < 3)
            {
                PrintLoop(a + 1);
            }
        }
    }
}
