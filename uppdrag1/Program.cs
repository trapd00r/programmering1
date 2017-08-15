/* 
   Uppdrag 1 "Pension"

 author: Magnus Woldrich
contact: m@japh.se
  mtime: 2017-08-14

*/


using System;
namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler
            string name, surname, age_input, author, teacher;
            int pension = 65;
            int age;
            author  = "Magnus Woldrich";
            teacher = "Oscar Antbring";

            // Ändra bakgrundsfärg i terminalen och redraw:a för
            // att inte enbart bakgrundsfärg bakom text skall ändras
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // Ändra default line terminator till "" för att slippa 
            // newline när input skall matas in
            Console.Out.NewLine = "";

            Console.WriteLine("  Fornamn: ");
            name = Console.ReadLine();

            Console.WriteLine("Efternamn: ");
            surname = Console.ReadLine();

            Console.WriteLine("    Alder: ");
            age_input = Console.ReadLine();
            // Försök förhindra ogiltig input när vi eftersöker ett heltal
            // Exceptions är dåliga som vi råkar ut för med int.Parse
            PARSE_TO_INT:
            if(!int.TryParse(age_input, out age)) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Inte en giltig alder!\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("    Alder: ");
                age_input = Console.ReadLine();
                // Visst är det mer okej med goto idag än när det
                // deklarerades "considered harmful" för många år sedan?
                goto PARSE_TO_INT;
            }
            
            // Använd ToUpper() för att kunna göra jämförelsen oavsett hur 
            // användaren matar in sitt namn
            if(name.ToUpper() + ' ' + surname.ToUpper() == teacher.ToUpper()) {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(name.ToUpper() + ' ' + surname.ToUpper() == author.ToUpper()) {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            // Jag saknar en TitleCase()-funktion för att göra för- och efternamns första
            // char uppercase. För övrigt brist på svenska tecken, då jag har
            // encodingproblem vid utmatning som jag inte har lyckats lösa.
            Console.WriteLine(
                "\nTjena {0} {1}!\nOm {2} ar skall du pensioneras :(\n",
                name, surname, (pension-age)
            );
            // Städa upp efter oss för att inte lämna terminalen i mayhem
            // när programmet avslutas
            Console.ResetColor();
            // Behövs antagligen inte, men better safe than sorry
            Console.Out.NewLine = "\r\n";
        }
    }
}
