using System.Diagnostics;
using System;
using System.Threading;

namespace Class_Excersizes
{
    class Program
    {

        static void Main(string[] args)
        {
            //declaring variables
            string name;
            
            Console.WriteLine("Plese enter your name:");
            name = Console.ReadLine();

            if (name == "shalev" || name == "Shalev");
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fuck you!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fuck you!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Fuck you!");
                
                Thread.Sleep(1500);
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                
            }
        }

    }
}
