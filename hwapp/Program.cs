using System;
namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler
            int pension=65;
            int age;
            string name; 
            string surname;
            // Ändra default line terminator till "" för att slippa 
            // newline när input skall matas in
            Console.Out.NewLine = "";

            Console.WriteLine("  Fornamn: ");
            name = Console.ReadLine();

            Console.WriteLine("Efternamn: ");
            surname = Console.ReadLine();

            Console.WriteLine("    Alder: ");
            // använd int.Parse() för att se till så att vi får ett heltal
            // om inte, kastar vi en exception
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "\nTjena " + name.ToUpper() + " " + surname + "! Om " + (pension -age) + " ar ar du dags att pensioneras!"
            );
        }
    }
}
