using System;

namespace _3_Escopo
{
    class Program
    {
        static int variavelDaClasse = 1;
        static void Main(string[] args)
        {
            
            Teste();
            //Console.WriteLine(variavelDaFuncao); -> Esta fora do escopo
            Console.WriteLine(variavelDaClasse);// -> Dentro do escopo "global"
            Console.ReadKey();
        }
        static void Teste()
        {
            int variavelDaFuncao;
            Console.WriteLine(variavelDaClasse);
        }
    }
}
