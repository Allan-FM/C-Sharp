using System;

namespace _2_Escopo_de_variáveis
{
    class Program
    {
        //Variaval na classe
        static int num = 10;
        static void Main(string[] args)
        {
            int num2 = 0;
            Teste();
            Console.WriteLine(num);
            Console.ReadKey();
        }
        static void Teste()
        {
            //Console.WriteLine(num); -> nao pode ser usada
            //Criar outra variavel  
            int num3 = 0;
            Console.WriteLine(num);//-> esta no escopo global
        }
    }
}
