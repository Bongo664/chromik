using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciag = "ABCDEFGHIJKLMNOPRSTQWUZYZ0123456789";
            string[] tablica_ciagow = { "napis1", "napis2", "napis3" };

            //dlugosc ciagu
            int dl = ciag.Length;

            //dodawanie ciągów
            string c1 = "0123456789";
            string c2 = "6789";
            string c3 = c1 + c2;
            string c5 = c3 + c1[2];
            string c4 = string.Join(" ", tablica_ciagow);

            //Wycinanie ze string
            string partof;
            partof = ciag.Substring(2);

            //Czy dany ciąg zawiera 
            bool czyzawiera = c1.Contains("2");

            //Na której pozycji zawiera
            int pozycja = c1.IndexOf("2");

            //Zamiana na duże liczby
            string odczyt = "tak";
            string parametr = odczyt.ToUpper();

            //Podział stringa
            string do_podzialu = "10.5 12.6 12.0 21.3 23.2";
            string[] temperatury = do_podzialu.Split(' ');

            //Podmiana  
            string zawiera_spacje = "A BC D EFG";
            string bez_spacji = zawiera_spacje.Replace(" ", "");

            //Usunięcie fragmentu
            string do_obrobki = "ABCD0123EFG";
            string po_obrobce = do_obrobki.Remove(4, 4);
            string po_obrobce2 = do_obrobki.Remove(do_obrobki.IndexOf("0123"), 4);
        }
    }
}
