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
            Console.WriteLine("lekcja programowania");
            var Ini = new ConfigFile(@".\Config.ini");
            string wartosc_parametru;
            wartosc_parametru = Ini.Read("IpAddress", "Drukarka");
            Console.WriteLine("ip address=" + wartosc_parametru);
            wartosc_parametru = Ini.Read("port", "Drukarka");
            Console.WriteLine("port=" + wartosc_parametru);
            string nazwa_drukarki;
            wartosc_parametru = Ini.Read("nazwa_drukarki", "Drukarka");
            if (string.IsNullOrEmpty(wartosc_parametru))
            {
                nazwa_drukarki = "default_name";
                Ini.Write("nazwa_drukarki", nazwa_drukarki, "Drukarka");
            }
            else if(!string.IsNullOrEmpty(wartosc_parametru))
            {
                nazwa_drukarki = wartosc_parametru;
            }
            Console.ReadLine();
        }
    }
}
