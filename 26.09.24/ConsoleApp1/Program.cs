using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź dolną granicę zakresu:");
            string nizszaliczba = Console.ReadLine();
            if (!int.TryParse(nizszaliczba, out int nizsza))
            {
                Console.WriteLine("Niepoprawne dane wejściowe. Proszę wprowadzić prawidłową liczbę.");
                return;
            }

            Console.WriteLine("Wprowadź górną granicę zakresu:");
            string wyrzszaliczba = Console.ReadLine();
            if (!int.TryParse(wyrzszaliczba, out int wyrzsza))
            {
                Console.WriteLine("Niepoprawne dane wejściowe. Proszę wprowadzić prawidłową liczbę.");
                return;
            }

            if (nizsza >= wyrzsza)
            {
                Console.WriteLine("Niepoprawny zakres. Dolna granica musi być mniejsza niż górna granica.");
                return;
            }

            Random rnd = new Random();
            int liczbarnd = rnd.Next(nizsza, wyrzsza + 1);
            Console.WriteLine("Zgadnij liczbę (pomiędzy " + nizsza + " a " + wyrzsza + "):");

            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int zga))
                {
                    Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                    continue;
                }

                if (zga == liczbarnd)
                {
                    Console.WriteLine("Gratulacje! Zgadłeś poprawną liczbę: " + liczbarnd);
                    break;
                }
                else if (zga < liczbarnd)
                {
                    Console.WriteLine("Twoja propozycja jest za niska. Spróbuj wyższej liczby.");
                }
                else
                {
                    Console.WriteLine("Twoja propozycja jest za wysoka. Spróbuj niższej liczby.");
                }
            }
        }
    }
}
