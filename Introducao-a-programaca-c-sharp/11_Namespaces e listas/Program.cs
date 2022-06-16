using System;
using System.Collections.Generic;
namespace _11_Namespaces_e_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArrays = new int[3];
            myArrays[0] = 1;
            myArrays[1] = 2;
            List<int> myList = new List<int>(3);
            myList.Add(-23);
            myList.Add(-23);
            myList.Add(-23);
            myList.Remove(5);
            myList.RemoveAt(4);
            //comandos -> funcoes -> classes -> namespaces -> assembly -> projeto
            Console.ReadKey();
        }
    }
}
