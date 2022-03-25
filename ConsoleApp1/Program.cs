using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak Ci na imie?");
            Console.Write("Napisz tutaj swoje imie: ");
            string imie = Console.ReadLine();
            if (imie.Length == 0)
            {
                Console.Error.WriteLine("\n\n\t*** Blad: nie podano imienia!\n\n");
                return;
            }
            bool niewiasta = imie.ToLower()[imie.Length - 1] == 'a';
            if (imie == "Kuba" || imie == "Barnaba" || imie == "kuba" || imie == "barnaba") niewiasta = false;
            Console.WriteLine(
                "Niech zgadne, jestes " + (niewiasta ? "dziewczyna " : "chlopakiem ") + "!");

            Console.WriteLine("Nacisnij Enter...");
            Console.Read();
        }
    }
}
