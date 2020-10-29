using System;

namespace SymbolsAndStrings
{
    class Program
    {

        static void Main()
        {
            var ship = "теплоход";
            var thing =  " " + ship[7] + ship[1] + ship.Substring(3, 2);
            var coldness = ship.Substring(5, 2) + ship.Substring(3, 2) + ship[7];
            Console.WriteLine($"Из слова теплоход мы получили слова:{coldness},{thing}");

            Console.ReadKey();
        }
    }
}