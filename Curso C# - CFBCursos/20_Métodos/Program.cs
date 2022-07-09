using System;

namespace _20_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Mensagem");
            Soma(1,44);
            Console.ReadKey();
        }

        //Metodo
        static void PrintLine(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static void Soma(int x, int y)
        {
            int res = x + y;
            Console.WriteLine($"A soma entre {x} e {y} = {res}");
        }
    }
}
