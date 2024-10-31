using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Zapisz_do_pliku("3CT - 2024");
            program.Zapisz_do_pliku("3CT");
            string linia=program.Odczytaj_z_pliku();
        }

        private void Zapisz_do_pliku(string text)
        {
            string path = @".\Plik.txt";
            StreamWriter zapisz = new StreamWriter(path, true);
            try
            {
                zapisz.WriteLine(text);
                zapisz.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                zapisz.Close();
            }
        }

        private void Zapisz_do_pliku_using(string text)
        {
            string path = @".\Plik2.txt";
            using (StreamWriter zapisz = new StreamWriter(path, true))
            {
                zapisz.WriteLine(text);
            }
        }
        private string Odczytaj_z_pliku()
        {
            string text = "";
            using (StreamReader odczytaj = new StreamReader(@".\Plik.txt"))
            {
                text = odczytaj.ReadLine();
                return text;
            }
        }
    }
}