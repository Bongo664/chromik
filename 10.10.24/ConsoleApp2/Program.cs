using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum typ_skrzyni
        {
            manualna = 1,
            automatyczna = 2
        }
        enum dni_tygodnia
        {
            poniedzialek=1,
            wtorek = 2,
            sroda = 3,
            czwartek = 4,
            piatek = 5,
            sobota = 6,
            niedziela = 7
        }
        static void Main(string[] args)
        {
            
            int skrzynia_biegow;
            skrzynia_biegow = 1;
            if (skrzynia_biegow == 1)
            {
                Console.WriteLine("skrzynia manualna");
            }
            else if(skrzynia_biegow==2)
            {
                Console.WriteLine("skrzynia automatyczna");
            }
            typ_skrzyni typ_Skrzyni = typ_skrzyni.automatyczna;
            if (skrzynia_biegow == (int)typ_skrzyni.manualna)
            {
                Console.WriteLine("skrzynia manualna");
            }
            else if (skrzynia_biegow == (int)typ_skrzyni.automatyczna)
            {
                Console.WriteLine("skrzynia automatyczna");
            }
            int liczba_dni;
            liczba_dni = 5+(int)dni_tygodnia.czwartek;

            Console.ReadLine();
        }
    }
}