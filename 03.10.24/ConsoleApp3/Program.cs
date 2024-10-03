using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haslo = " ";
            string znaki = Console.ReadLine();
            int i = 0;
            while (i < 15)
            {
                Random x = new Random();
                int y = x.Next(15);
                haslo += haslo + znaki.Substring(y);
                Console.WriteLine(haslo);
            }
            Console.ReadKey();
        }
    }
}
