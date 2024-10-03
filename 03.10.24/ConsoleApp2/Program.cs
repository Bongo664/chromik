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
            PromptForInput();
        }

        static void PromptForInput()
        {
            Console.WriteLine("Podaj ciąg znaków dłuższy niż 12:");
            string input = Console.ReadLine();

            if (input.Length <= 12)
            {
                Console.WriteLine("Ciąg jest za krótki. Spróbuj ponownie.");
                PromptForInput();
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
    }
}