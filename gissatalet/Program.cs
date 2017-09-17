// gissa talet

using System;

namespace gissatalet {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("------- gissa talet -------");

            Random randomerare = new Random();
            int slumptal = randomerare.Next(1, 101);

            /* gör en tilldelning, annars klagar kompilatorn på use of unassigned local variable */
            string user_input = "";
            int guess;
            int antal_gissningar = 0;

            /* min första funktion i C# \o/ */
            int parsa_till_int() {
                Console.Write("Heltal: ");
                user_input = Console.ReadLine();

                // håll reda på antal gissningar!
                antal_gissningar++;

                // se till att vi får ett giltigt heltal av användaren
                while(!int.TryParse(user_input, out guess)) {
                    Console.Write("Det var inte ett heltal!\nHeltal: ");
                    user_input = Console.ReadLine();
                }
                return guess;
            }

            while(parsa_till_int() != slumptal) {
                if(guess + 10 < slumptal) {
                    Console.WriteLine("Mycket storre!");
                }
                if(guess - 10 > slumptal) {
                    Console.WriteLine("Mycket mindre!");
                }
//                Console.WriteLine("[Secret random: {0}]", slumptal);
            }
            Console.WriteLine("Du gissade ratt!\n");
            Console.WriteLine("Heltalet vi letade efter var: {0} och det kravdes {1} gissningar!", slumptal, antal_gissningar);
        }
    }
}