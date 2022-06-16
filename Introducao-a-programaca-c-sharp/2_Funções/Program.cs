using System;

namespace Desafio___Reproduzindo_o_dialogo_do_pokemon
{
    class Program
    {
        static void Main(string[] args)
        {

        }     

        static void MinhaFuncaoComParametros(string a, int x, int y)
        {
            //comandos da funcao
        }
        static void MinhaFuncaoSemParametros()
        {
            //comandos da funcao
        }
        static string FuncaoComRetorno()
        {
            return "Oi"; //-> linha obrigatoria
        }
        static string ReadNameInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
