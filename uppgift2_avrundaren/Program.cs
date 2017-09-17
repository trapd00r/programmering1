// uppgift 2 - avrundaren

using System;

namespace uppgift2_avrundaren
{
    class Program
    {
        static void Main(string[] args)
        {
            string decimaltal;
            float flyttal;

            Console.Write("Skriv in ett decimaltal: ");
            decimaltal = Console.ReadLine();
            Console.WriteLine(" ---------- ");

            /* 
              Om användaren inte lyckas skriva in ett giltigt decimaltal, fråga igen och igen.
              Notera att du (beroende av locale) kan behöva använda olika slags decimaltecken:
              , sverige
              . resten, ungefär
            */
            while(!Single.TryParse(decimaltal, out flyttal)) {
                Console.Write("Inte ett flyttal. Forsok igen: ");
                // egentligen är det slöseri att ha exakt samma statement här i loopen som på
                // rad 15, men det är åtminstonde tydligt vad som sker.
                decimaltal = Console.ReadLine();
            }

            /*
            Jag vet hur jag vill lösa den delen av uppgiften som handlar om att användaren skall få mata in 
            önskat antal decimaler själv. 
            Pseudokod:

              int decimaler;
              Console.Write("Med önskat antal decimaler: {0:f${decimaler}}, flyttal);

            Där ${decimaler} symboliserar en interpolation av variabeln decimaler, interpolationen expanderas
            och givet att användaren matar in "7" som önskat antal decimaler så ser den delen av koden ut så här:
              {0:f7}
            dvs, sträng med index 0 skrivs ut med 7 decimalers precision

            Dock blir jag inte klok på om man KAN göra så här i C#. Jag har läst och googlat på interpolation av
            strängar men jag hittar inte det jag söker.

            Två frågor till dig: 
            - KAN jag göra så?
            - BÖR jag göra så? Vad är "rätt" sätt? 
            */

            Console.Write(
                " Math.Round: {0}\n3 decimaler: {1:f3}\n",
                flyttal, Math.Round(flyttal, 3));

        }
    }
}