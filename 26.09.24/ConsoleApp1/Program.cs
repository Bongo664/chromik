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
            int JeszczeRaz = 1;
            while (JeszczeRaz == 1)
            {
                int a = 0;

                Console.WriteLine("Podaj do której liczby ma być zgadywane: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Liczba musi być większa od 0: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                else if (a > 0)
                {
                    Console.WriteLine("Zgaduj liczbę: ");

                    Random r = new Random();
                    int b = r.Next(a);

                    int liczba = Convert.ToInt32(Console.ReadLine());

                    while (liczba != b)
                    {
                        if (liczba > b)
                        {
                            Console.WriteLine("Liczba jest za duża próbuj dalej ");
                            liczba = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (liczba < b)
                        {
                            Console.WriteLine("Liczba jest za mała próbuj dalej ");
                            liczba = Convert.ToInt32(Console.ReadLine());
                        }
                        if (liczba == b)
                        {
                            Console.WriteLine("Brawo Zgadłeś chcesz zagrać ponownie jeśli Tak = 1 a jeśli Nie = 0");
                        }
                    }
                    JeszczeRaz = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.ReadKey();

        }
    }
}
