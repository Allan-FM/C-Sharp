using System;
using System.Net.Cache;

namespace _22_Argumento_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendoMain = 10;
            int divisorMain = 5;
            int rest;
            int quoce = Dividadendo(dividendoMain, divisorMain,out rest);
            Console.WriteLine($"quociente = {quoce} \nresto = {rest}");
            Console.ReadKey();
        }
        static int Dividadendo(int dividendo, int divisor, out int resto)
        {
            int cosiente;
            cosiente = dividendo / divisor;
            resto = dividendo % divisor;
            return cosiente;
        }
    }
}
