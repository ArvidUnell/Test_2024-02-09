using System;
using System.Diagnostics.SymbolStore;

namespace Test_2024_02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "3")
            {
                Console.WriteLine("1: Konvertera från farenheit till celsius");
                Console.WriteLine("2: Konvertera från celsius till farenheit");
                Console.WriteLine("3: Avsluta programmet");
                svar = Console.ReadLine();

                double input;
                switch (svar)
                {
                    case "1":
                        Console.WriteLine("Skriv in värdet du vill konvertera från farenheit till celsius");
                        input = ReadDouble();

                        Console.WriteLine($"{input} grader farenheit är {Math.Round(Celsius(input),2)} grader celsius.");
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Skriv in värdet du vill konvertera från celsius till farenheit");
                        input = ReadDouble();

                        Console.WriteLine($"{input} grader celsius är {Math.Round(Farenheit(input),2)} grader farenheit.");
                        Console.WriteLine();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Ogiltigt svar. Försök igen");
                        break;
                }
            }
        }
        static double Celsius(double F)
        {
            return (F - 32) / 1.8;
        }
        static double Farenheit(double C)
        {
            return 32 + C * 1.8;
        }
        /// <summary>
        /// Läser in ett double-tal från användaren
        /// </summary>
        /// <returns>Talet användaren skrev</returns>
        static double ReadDouble()
        {
            double dubbel;
            while (!double.TryParse(Console.ReadLine(), out dubbel))
            {
                Console.WriteLine("Ogiltigt svar. Försök igen");
            }
            return dubbel;
        }
    }
}