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
            
            Console.WriteLine("Podaj dzielną:");
            if (int.TryParse(Console.ReadLine(), out int dzielna)){
                Console.WriteLine("Podaj dzielik:");
                int dzielnik = Convert.ToInt32(Console.ReadLine());
                if (dzielnik == 0)
                {
                    Console.WriteLine("Dzielnik nie moze byc 0");
                }
                else
                {
                    Zapisz_wynik_dzielenia(dzielna, dzielnik);
                }
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Blednie podane dane");
            }

        }
        static void Zapisz_wynik_dzielenia(int a, int b)
        {
            Console.WriteLine("wynik dzielenia=" + (a / b).ToString());
        }
        static void przyklad()
        {
            try
            {
                //kod obsługiwany
                int a = 12;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Wynik dzielenia=" + c.ToString());
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("dzielenie przez zero zabronione");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("wystapil blad" + e.ToString());
                Console.ReadKey();
            }
        }
    }
}
