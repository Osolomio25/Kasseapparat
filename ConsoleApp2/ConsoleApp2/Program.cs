using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //                 Key      Value
        //static List<string, double> katalog = new List<string, double>(); 
        static Dictionary<string, double> katalog = new Dictionary<string, double>();
        static List<KeyValuePair<string, double>> valgtevare = new List<KeyValuePair<string, double>>();
        //Æble, 123
        //banan, 123
        //pære, 123

        static void Main(string[] args)
        {

         //pre-defineret Dictonary vednavn katalog
         katalog.Add("æble", 5);
         katalog.Add("banan", 10.10);
         katalog.Add("pære", 6.9);
         katalog.Add("melon", 10.89);
         katalog.Add("galia", 20.21);
        
         string kpenge = "";

         Console.Write("Indtast kundens penge: ");
         kpenge = Console.ReadLine();
         
         double dkpenge = 0;
         dkpenge = Convert.ToDouble(kpenge);
         //Console.Write("Invalid indtastning, prøv igen: ");

         Console.WriteLine("Du kan vælge imellem: ");

         //Indsætter valgte vare i variablen vare, fra katalog
         foreach (var vare in katalog)
            {
                Console.WriteLine($"{vare.Key}\t{vare.Value}");
            }

         Console.Write("Afslut med exit, indtast vare: ");

         //Hvis der skrives exit, slutter den while loopen
         string newline = "";
         while ((newline = Console.ReadLine()) != "exit")
            {
                //Her ligges vare i listen valgtevare og der tjekkes samtidig om varen eksisterer i katalog
                // While loop i If loop
                if (katalog.ContainsKey(newline))
                {
                    valgtevare.Add(new KeyValuePair<string, double>(newline, katalog[newline]));
                    Console.Write("Indtast ny vare: ");
                }
                else
                    Console.Write("Ugyldig vare, indtast igen: ");
            }

         Console.WriteLine("Kvittering: ");
           
         //For hver vare der blev skrevet ind i valtevare listen, blibver udskrevet, hernæst bliver summen samlet
         double totalt = 0;
         foreach (var vare in valgtevare)
            {
                Console.WriteLine($"{vare.Key}\t{vare.Value}");
                totalt = totalt + vare.Value;
            }

         double tpenge = dkpenge - totalt;

         string totalt1 = totalt.ToString("C");
         string tpenge1 = tpenge.ToString("C");

         string tpenge2 = string.Format("{0:0.0}", tpenge);


         Console.WriteLine(DateTime.Now);
         Console.WriteLine($"Total:\t{totalt1}");
         Console.WriteLine($"Retur:\t{tpenge1}");
         Console.WriteLine($"Udbetalt:\t{tpenge2}");

         Console.ReadKey();
        }
    }
}