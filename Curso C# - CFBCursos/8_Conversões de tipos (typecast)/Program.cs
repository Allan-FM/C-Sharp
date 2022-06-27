using System;

namespace _8_Conversões_de_tipos__typecast_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            short shortnumber= (short)number;
            float number2 = 2.3f;
            int res = (int)number2;
            Console.WriteLine(res);
            Console.WriteLine(shortnumber);
            Console.ReadKey();
        }
    }
}
