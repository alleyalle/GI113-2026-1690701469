/*
* Student ID : 1690701469
* Name       : Natchanun kosaiyaseth
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reactorHeat = 120;

            Console.WriteLine("=== REACTOR OVERLOAD ===");
            Console.WriteLine("Warning, the core is overheating, you need to cool it down immediately, but stay calm, cooling too fast could crack the core");
            Console.WriteLine("Current Heat: " + reactorHeat + "");
            Console.WriteLine("You need to bring the heat below 40 in 3 rounds but not too low, or the core will freeze and shatter.");
            Console.WriteLine("Caution! : reactor heat rises by 15 every round, calculate carefully before you act");
            Console.WriteLine("Okay , let's stabilize the reactor!");
            Console.WriteLine();
            Console.WriteLine("=== CONTROL PANEL ===");
            Console.WriteLine("1) Coolant Vent | -35 Heat ");
            Console.WriteLine("2) Emergency Flush | -55 Heat ");
            Console.WriteLine("3) Fan Boost | -15 Heat");
            Console.Write("Choose your action first (1-3): ");

            bool firstChoice = int.TryParse(Console.ReadLine(), out int fChoice);

            if (!firstChoice || fChoice < 1 || fChoice > 3)

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Its not in the choices, you didn't press anything");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (fChoice == 1)

            {
                reactorHeat = reactorHeat - 35;
                Console.WriteLine();
                Console.WriteLine("You vent the coolant lines like your life depends on it, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();

            }

            else if (fChoice == 2)

            {
                reactorHeat = reactorHeat - 55;
                Console.WriteLine();
                Console.WriteLine("You trigger the emergency flush and the whole room shakes, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (fChoice == 3)

            {
                reactorHeat = reactorHeat - 15;
                Console.WriteLine();
                Console.WriteLine("Just why? You had two better options right there but you chose the fan? ,now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            reactorHeat = reactorHeat + 15;
            Console.WriteLine("Heat increased 15 = " + reactorHeat + ".");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== CONTROL PANEL ===");
            Console.WriteLine("1) Pressure Release | -25 Heat ");
            Console.WriteLine("2) Full Shutdown Sequence | -60 Heat ");
            Console.WriteLine("3) Manual Fan Spin | -5 Heat");
            Console.Write("Choose your action next (1-3): ");

            bool secondChoice = int.TryParse(Console.ReadLine(), out int sChoice);

            if (!secondChoice || sChoice < 1 || sChoice > 3)

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Its not in the choices, you didn't press anything");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (sChoice == 1)

            {
                reactorHeat = reactorHeat - 25;
                Console.WriteLine();
                Console.WriteLine("You release pressure through the vents, you feel great because you played it safe, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (sChoice == 2)

            {
                reactorHeat = reactorHeat - 60;
                Console.WriteLine();
                Console.WriteLine("You initiate a full shutdown like slamming the brakes on a train, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (sChoice == 3)

            {
                reactorHeat = reactorHeat - 5;
                Console.WriteLine();
                Console.WriteLine("Okay? that barely did anything, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            reactorHeat = reactorHeat + 15;
            Console.WriteLine("Heat increased 15 = " + reactorHeat + ".");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== CONTROL PANEL ===");
            Console.WriteLine("1) Deep Freeze Injection | -95 Heat ");
            Console.WriteLine("2) Backup Coolant Tank | -40 Heat ");
            Console.WriteLine("3) Pull The Core | ??? Heat");
            Console.Write("Choose your action next (1-3): ");

            bool thirdChoice = int.TryParse(Console.ReadLine(), out int tChoice);

            if (!thirdChoice || tChoice < 1 || tChoice > 3)

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Its not in the choices, you didn't press anything");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (tChoice == 1)

            {
                reactorHeat = reactorHeat - 95;
                Console.WriteLine();
                Console.WriteLine("You inject the deep freeze coolant straight into the core, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (tChoice == 2)

            {
                reactorHeat = reactorHeat - 40;
                Console.WriteLine();
                Console.WriteLine("You switch to the backup coolant tank, solid backup plan, now the Heat is " + reactorHeat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (tChoice == 3)

            {
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("You look at the exposed core, sparks and steam pouring out.");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("The alarms fade into silence. ");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("The core is lost.");
                Thread.Sleep(10000);
                return;
            }

            Console.WriteLine("=== REACTOR SUMMARY ===");

            if (reactorHeat < 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You overcooled the core, it's cracking");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (reactorHeat > 40)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The reactor is still overheating!");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Great! the reactor is stable, have a good day!");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}