using System;

namespace bastu {
  internal class Program {

    private static double fahr_to_cel(double fahr) {
      // returnera en double, avrundat till EN decimal.
      return Math.Round( (double)(fahr - 32) * 5 / 9, 1);
    }
    
    // metodöverlagring, för när användaren matar in en nolla och vill ha 
    // en slumpad temperatur.
    private static int fahr_to_cel() {
      Random random = new Random();
      return random.Next(0, 512);
    }

    private static int cel_to_fahr(int cel) {
      // implementerade en motsvarande celcius till fahrenheit-funktion.
      // användes vid debuggning
      return cel * 9 / 5 + 32;
    }

    public static void Main(string[] args) {
      // optimal, minimum och maximum temperatur, i celcius
      int temp_opt = 75;
      int temp_max = 77;
      int temp_min = 73;

//      // samma temperaturer, men i fahrenheit
//      int temp_opt_f = cel_to_fahr(temp_opt);
//      int temp_max_f = cel_to_fahr(temp_max);
//      int temp_min_f = cel_to_fahr(temp_min);

      /* Lite färg piffar upp. Trist att det är så komplicerat att handskas
         med den underliggande terminalen ifrån C#. Det känns som en
         begränsning både i språket men framförallt kanske i cmd.exe.
         Jag vet att det går att skicka vissa escape-sekvenser till cmd (jag
         har gjort det i andra språk), men försöker man göra det via C# så 
         tar det stopp: "Unrecognized escape sequence". Man skall väl få skicka
         vilken data man helst önskar, eller? ...
         
         Borde funka:
         Console.Write("\e[1mtext i bold\e[m");
         Samma sak:
         Console.Write("\033[1mtext i bold\e[m");
      */
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("Välkommen till ");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("bastun!");
      Console.ResetColor();
      
//      Console.WriteLine("Optimal temp: {0}C ({1}F)", temp_opt, temp_opt_f);
//      Console.WriteLine("    Max temp: {0}C ({1}F)", temp_max, temp_max_f);
//      Console.WriteLine("    Min temp: {0}C ({1}F)", temp_min, temp_min_f);

      // sätt värde till tom sträng, så vi kan sköta logik direkt i
      // while-loopen och undvika upprepningar
      string fahr_input = "";
      int fahr_ok;

      while (!int.TryParse(fahr_input, out fahr_ok)) {
        Console.Write("Fahrenheit: ");
        fahr_input = Console.ReadLine();
      }

      double fahr_final;
      
      // Kontrollera om användaren vill ha en random temperatur
      fahr_final = (fahr_ok == 0 ? fahr_to_cel() : fahr_to_cel(fahr_ok));

      if (fahr_final == temp_opt) {
        Console.WriteLine("Bastun har uppnått optimal temperatur: {0}°C", fahr_final);
      }
      else if (fahr_final > temp_min && fahr_final < temp_max) {
        Console.WriteLine(" {0}° är en godtagbar temperatur.", fahr_final);
      }
      else if (fahr_final < temp_min) {
        Console.WriteLine("{0}°C! Brr! Skruva upp tempen!", fahr_final);
      }
      else if (fahr_final > temp_max) {
        Console.WriteLine("{0}°C! Skruva ned värmen Britta!", fahr_final);
      }
      
      Console.ReadKey();

    }
  }
}


