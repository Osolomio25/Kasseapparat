using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Indtast navn: ");
            string navn = Console.ReadLine();

            Console.Write($"Velkommen til {navn}");

            Console.ReadKey();
        }
    }
}
