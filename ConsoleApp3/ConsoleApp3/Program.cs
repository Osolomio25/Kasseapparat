using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 
            Console.Write("Indtast tal: ");


            Regex nr = new Regex(@"^\d$");
            if (Regex.IsMatch(newtal))
            {
                Console.WriteLine($"Du har indtastet: {tal}");
            }

            else
            {
                Console.Write("Forkert indtastning, prøv igen: ");
            }
        }
    }
}
