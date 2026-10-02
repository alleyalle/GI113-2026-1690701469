/*
* Student ID : 1690701469
* Name : Natchanun Kosaiyaseth
* Section : 129B
* No.  : -
* Course : GI113 Computer programmimg (GI)
*/

using System.ComponentModel.Design;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Material = "Iron";
            const double SalvageRate = 0.300;
            const double MaxBatch = 500;
            const double SmeltRate = 0.250;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------");
            Console.WriteLine(">>> Welcome to the Forge <<<");
            Console.WriteLine($"--> {Material} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine(" Press 'B' for breakdown (Ingot >> Ore) ");
            Console.WriteLine(" Press 'S' for smelt (Ore >> Ingot) ");
            Console.WriteLine("-----------------------------");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose Menu");
            bool isMenuParsed = char.TryParse(Console.ReadLine(), out char menu);
            Console.WriteLine("How much would you like: ");
            bool isAmountParsed = double.TryParse(Console.ReadLine(),out double amount);

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (isAmountParsed && amount > 0 && amount <= MaxBatch)
            {
                if (isMenuParsed && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.WriteLine($" {amount:F2} {Material} Ore = {ingot:F2} {Material} Ingot");
                }

                else if (isMenuParsed && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine($" {amount:F2} {Material} Ingot = {ore:F2} {Material} Ore");
                }
                else
                {
                    Console.WriteLine("Invalid menu Press key 'S' or 'B' ");
                }
            }
            else
            {
                Console.WriteLine($"Invalid amount Please use a number more than 0 and not over {MaxBatch}");
            }
        }
    }
}
