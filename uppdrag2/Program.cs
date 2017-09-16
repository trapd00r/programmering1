using System;
using System.Drawing;
using Console = Colorful.Console;
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=0;i<17;i++) {
                Console.WriteLine(i, Color.LightGoldenrodYellow);
            }
//            while(true) {
//                Console.Write("> ");
//                input = Console.ReadLine();
//                Console.Write("["+input+"]\n");
//                System.Threading.Thread.Sleep(2500);
//            }
//        }
    }
}
