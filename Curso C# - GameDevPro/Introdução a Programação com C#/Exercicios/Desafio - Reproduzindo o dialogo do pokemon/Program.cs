using System;

namespace Desafio___Reproduzindo_o_dialogo_do_pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Intruduction();

            PrintSeparator();

            InputPlayerName();

            PrintSeparator();

            InputRivalName();

            PrintSeparator();

            FinalDialogue();
        }
        static void Intruduction()
        {
            PrintAndWait("Olá pessoal! Bem vindos ao mundo pokemon!!");
            PrintAndWait("Sou Carvalho, mas pode me chamar de pokemon PROF!");
            PrintAndWait("Estudo pokemons como profissão");
        }
        static void InputPlayerName()
        {
            string nomeDoPlayer = ReadNameInput("Primeiro, qual é o seu nome -> ");
            PrintAndWait($"Tudo bem seu nome é: {nomeDoPlayer}");
        }
        static void InputRivalName()
        {
            PrintAndWait("Apresento o meu neto, ele é o seu rival desde que voces nasceram!");
            string nomeDoRival = ReadNameInput("Eu esqueci o nome do rapaz! Voce pode me lembrar no nome dele -> ");
            PrintAndWait($"Claro! Agora eu me lembrei o nome dele é: {nomeDoRival}");
        }
        static void PrintAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static void FinalDialogue()
        {
            PrintAndWait("Ache todos os pokemons lendario desse mundo!");
            PrintAndWait("Um mundo de aventuras começa agora!!!");
        }
            

        static string ReadNameInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
        static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();
        }
    }
}
