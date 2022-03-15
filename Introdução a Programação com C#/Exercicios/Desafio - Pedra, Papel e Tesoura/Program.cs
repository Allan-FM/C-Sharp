using System;

namespace Desafio___Pedra__Papel_e_Tesoura
{
    class Program
    {
        enum RockPaperScissor
        {
            Rock, 
            Paper,
            Scissor
        }
        static void Main(string[] args)
        {
            PrintLineAndWait("Ola eu sou uma IA! E te desafio a jogar Pedra Papel Tesoura comigo.");
            Console.Write("Qual a sua opcao -> ");
            
            string escolhaDoJogadorString = Console.ReadLine();
            RockPaperScissor escolhaDoJogador =  Enum.Parse<RockPaperScissor>(escolhaDoJogadorString);
                switch (escolhaDoJogador)
                {
                    case RockPaperScissor.Paper:
                    PrintLineAndWait($"Jogador escolheu: {RockPaperScissor.Paper}");
                    PrintLineAndWait($"IA escouleu: {RockPaperScissor.Scissor}");
                    PrintLineAndWait("IA venceu!!! Tesoura corta Papel!");
                        break;
                    case RockPaperScissor.Rock:
                    PrintLineAndWait($"Jogador escolheu: {RockPaperScissor.Rock}");
                    PrintLineAndWait($"IA escolheu: {RockPaperScissor.Paper}");
                    PrintLineAndWait("IA venceu!!! Papel embrulha Pedra!");
                        break;
                    case RockPaperScissor.Scissor:
                        PrintLineAndWait($"Jogador escolheu: {RockPaperScissor.Scissor}");
                        PrintLineAndWait($"IA escolheu: {RockPaperScissor.Rock}");
                        PrintLineAndWait($"IA venceu!!! Pedra quebra tesoura!");
                        break;
                    default:
                        Console.WriteLine("As opcoes sao PEDRA, PAPEL ou TESOURA!");
                    break;
                }
            
        }

        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
