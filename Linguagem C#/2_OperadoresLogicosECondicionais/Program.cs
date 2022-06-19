using System;

namespace _2_OperadoresLogicosECondicionais
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
        static void CondicionalIfElse()
        {
            //if - else
            int number = 2;
            if (number == 1)
            {
                Console.WriteLine("O numero eh igual a 1");
            }
            else if (number == 2)
            {
                Console.WriteLine("O numero eh igual a 2");
            }
            else
            {
                Console.WriteLine("O numero nao eh igual a nada!");
            }
        }
        static void CondicionalSwitch()
        {
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
        static void OperadoresLogicos()
        {
            int num1 = 2;
            int num2 = 3;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
        }
    }
}
