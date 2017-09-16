using System;

namespace uppgift2_avrundaren
{
    class Program
    {
        static void Main(string[] args)
        {
            string decimaltal;
            float flyttal;
            Console.WriteLine("Skriv in ett decimaltal: ");
            decimaltal = Console.ReadLine();
            while(!Single.TryParse(decimaltal, out flyttal)) {
                Console.Write("Inte ett flyttal. Forsok igen: ");
                decimaltal = Console.ReadLine();
            }
            Console.Write("Input: {0}\n TryParse: {1}\n Math.Round: {2}\n n antal vardesiffror: {1:f3}\n", 
                decimaltal, flyttal, Math.Round(flyttal, 5));
        }
    }
}
