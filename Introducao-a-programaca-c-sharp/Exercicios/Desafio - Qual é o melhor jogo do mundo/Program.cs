using System;

namespace Desafio___Qual_é_o_melhor_jogo_do_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLineAndWait("Ola eu sou um genio e posso te conceder 3 desejos...");
            PrintLineAndWait("Mas antes me responda uma pergunta. Voce tem 3 tentativas.");
            string choiceGame = ReadTextInput("Qual e o melhor jogo do universo -> ");
            string bestGame = "God Of War 4";
            if(choiceGame != bestGame)
            {
                PrintLineAndWait("Resposta errada! Voce tem mais 2 tentativas.");
                choiceGame = ReadTextInput("Qual e o melhor jogo do universo -> ");
                if(choiceGame != bestGame)
                {
                    PrintLineAndWait("Resposta errada! Tua batata ta assando!");
                    choiceGame = ReadTextInput("Qual e o melhor jogo do universo -> ");
                    if(choiceGame != bestGame)
                    {
                        PrintLineAndWait("Voce nao sabe de nada mesmo... Vou procurar alguem que entende de jogos.");
                    }
                }
            }
            else if(choiceGame == bestGame)
            {
                Console.WriteLine("Voce acertou!!!! Voce entende de jogos!!");
            }
            Console.ReadKey();
        }
        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static string ReadTextInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
