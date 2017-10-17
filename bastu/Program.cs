using System;
using System.Collections.Generic;

namespace bastu {
  internal class Program {

    public static int fahr_to_cel(int fahr) {
      return (fahr - 32) * 5 / 9;
    }

    public static int cel_to_fahr(int cel) {
      return cel * 9 / 5 + 32;
      return (cel + 32) * 5 / 9;
    }
    public static void Main(string[] args) {
      int temp_opt = 75;
      int temp_max = 77;
      int temp_min = 73;

      int temp_opt_f = cel_to_fahr(temp_opt);
      int temp_max_f = cel_to_fahr(temp_max);
      int temp_min_f = cel_to_fahr(temp_min);
      
      Console.WriteLine("Välkommen till bastun!");
      Console.WriteLine("VARNING: Finska basturegler satta i /etc/basturc");
      
      Console.WriteLine("Optimal temp: {0}C ({1}F)", temp_opt, temp_opt_f);
      Console.WriteLine("    Max temp: {0}C ({1}F)", temp_max, temp_max_f);
      Console.WriteLine("    Min temp: {0}C ({1}F)", temp_min, temp_min_f);
      
      Console.Write("Fahrenheit: ");
      int fahr_input = int.Parse(Console.ReadLine()); // FIXME
      
      Console.WriteLine("Celcius: {0}", fahr_to_cel(fahr_input)); 
      Console.ReadKey();

    }
  }
}


