using System;

namespace _1_TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 1;
            //myInt = "All";

            var myVar = 2;

            float myFloat = 2.5f;
            
            double myDouble = 321.3212d;

            string myString = "Allala";

            bool myBool = true;
            
            Console.WriteLine(myVar);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(myDouble);

            //Cast
            float number1 = 4.4f;
            float number2 = 5.2f;
            int soma = (int)number1 + (int) number2;
            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}
