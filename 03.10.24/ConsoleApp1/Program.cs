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
            string ciag = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string[] tablica_ciagow = {"napis1", "napis2", "napis3" };
            Console.WriteLine(tablica_ciagow[0]);


            int dl = ciag.Length;
            string c1 = "812345";
            string c2 = "6789";
            string c3 = c1 + c2;
            string c5 = c3 + c1[2];
            string c4 = String.Join(" ", tablica_ciagow);
            string partof;
            partof = ciag.Substring(2, 5);
            bool czyzawiera = c1.Contains("2");
            int pozycja = c1.IndexOf("6");
            string odczyt = "tak";
            string parametr=odczyt.ToUpper();
            string do_podzialu = "10.5 12.6 12.0 21.3 23.2";
            string[] temperatury = do_podzialu.Split(' ');
            string zawiera_spacja = "A BC D EFG";
            string bez_spacji = zawiera_spacja.Replace(" ", "");
            string do_odrobki = "ABCD0123EFG";
            string po_obropce = do_odrobki.Remove(4, 4);
            string po_obropce2 = do_odrobki.Remove(do_odrobki.IndexOf("0123"), 4);
        }
    }
}
