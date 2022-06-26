using System;

namespace _7_Enumeradores__enum_
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado
        }
        static void Main(string[] args)
        {
            DaysOfTheWeek domingo = DaysOfTheWeek.Domingo;
            Console.WriteLine(domingo);

            DaysOfTheWeek segunda = (DaysOfTheWeek)1;
            Console.WriteLine(segunda);

            int terca  = (int)DaysOfTheWeek.Terca;
            Console.WriteLine(terca);

            Console.ReadKey();
        }
    }
}
