using System;

namespace _3_Formatando_a_saída_no_console
{
    class Program
    {
        static void Main(string[] args)
        {   
            double valorDeCompra = 5;
            double valorDaVenda;
            double lucro = 0.1;
            string nomeDoProduto = "Pastel";   

            valorDaVenda = valorDeCompra + (valorDeCompra * lucro);

            Console.WriteLine($"Nome do Produto -> {nomeDoProduto}");
            Console.WriteLine($"Valor do Produto -> {valorDeCompra:c}");
            Console.WriteLine($"Lucro do Produto -> {lucro}");
            Console.WriteLine($"Valor de venda -> {valorDaVenda:c}");

            Console.ReadKey();
        }
    }
}
