using System;

namespace _6_Operações_de_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10; 
            //num = num << 1;

            //Console.WriteLine(num); -> 20

            num = num >> 1;
            Console.WriteLine(num); // -> 5 

            Console.ReadKey();
        }
    }
}
