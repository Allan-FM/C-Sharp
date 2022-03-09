using System;

namespace _1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagemDoUsuario;
            mensagemDoUsuario = Console.ReadLine();
            Console.WriteLine(mensagemDoUsuario);

            //  Tipo de Variaveis

            int x = 2;
            float y = 2.5f;
            
            long myLong = 5000;
            double myDouble = 12345.12345d;

            char myChar = 'A';
            string myString = "Muitos char!";

            bool myBool = true; //-> Só true ou False


            Console.ReadKey();
        }
    }
}
