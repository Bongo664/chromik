using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie, nazwisko, nrTelefonu, adresEmail;
            int? stanKonta = null; //zmienna nullable
            bool czyPosiadaKonto;
            if (stanKonta == 0)
            {
                Console.WriteLine("Nie posiada konta");
            }
            else
            {
                Console.WriteLine("stan konta: " + stanKonta.ToString());
                //uzywanie interpolacji
                Console.WriteLine($"stan konta: {stanKonta}");
            }
            double? zmienna1 = null;
            double? zmienna2 = 100;
            double? zmienna3;
            zmienna3 = zmienna1 ?? zmienna2;
            Console.WriteLine($"Wartość zmiennej zmienna3 to {zmienna3}");
            Console.ReadKey();
        }
    }
}
