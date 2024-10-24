using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-utworz wartosc, 2-usun wartosc, 3-wyswietl wartosc");
                int wybierz = Convert.ToInt32(Console.ReadLine());
                var Ini = new ConfigFile(@".\Config.ini");
                if (wybierz == 1)
                {
                    Console.WriteLine("podaj dane parametru ze struktury. SEKCJA$PARAMETR%WARTOSC");
                    string stwo = Console.ReadLine();
                    int pol1 = stwo.IndexOf("$") + 1;
                    int pol2 = stwo.IndexOf("%") + 1;
                    string sekcja = stwo.Substring(pol1, pol1 - 1);
                    string parametr = stwo.Substring(pol2, (stwo.Length - pol2));
                    string wartosc = stwo.Substring(pol2+1);
                    Ini.Write(sekcja,parametr,wartosc);
                }
                else if (wybierz == 2) 
                {
                    Console.WriteLine("podaj dane parametru ze struktury. SEKCJA$PARAMETR");
                    string usun = Console.ReadLine();
                    int pol1 = usun.IndexOf("$") + 1;
                    int pol2 = usun.IndexOf("%") + 1;
                    string sekcja = usun.Substring(pol1, pol1 - 1);
                    string parametr = usun.Substring(pol2, (usun.Length - pol2));
                    Ini.DeleteKey(sekcja, parametr);
                    Console.WriteLine("Usunieto parametr");
                }
                else if (wybierz == 3)
                {
                    Console.WriteLine("podaj dane ze struktury. SEKCJA$PARAMETR");
                    string odczyt = Console.ReadLine();
                    int pol1 = odczyt.IndexOf("$") + 1;
                    int pol2 = odczyt.IndexOf("%") + 1;
                    string sekcja = odczyt.Substring(pol1, pol1 - 1);
                    string parametr = odczyt.Substring(pol2, (odczyt.Length - pol2));
                    string od = Ini.Read(parametr, sekcja);
                }
                Console.ReadLine();
            }
        }
    }
}
