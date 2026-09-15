/*
* Student ID : 1690701469
* Name       : Natchanun kosaiyaseth
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Justin
            Console.WriteLine("==>>> FOLLOW ME HOME <<<==");
            Console.WriteLine("Justin vs. The Presence -- Calculate Damage");

            Console.Write("Justin HP: ");
            bool justinHpOk = int.TryParse(Console.ReadLine(), out int justinHp);
            Console.Write("Justin Force: ");
            bool justinForceOk = int.TryParse(Console.ReadLine(), out int justinForce);
            Console.Write("Justin Guard: ");
            bool justinGuardOk = int.TryParse(Console.ReadLine(), out int justinGuard);

            // The Presence
            Console.Write("Presence HP: ");
            bool presenceHpOk = int.TryParse(Console.ReadLine(), out int presenceHp);
            Console.Write("Presence Force: ");
            bool presenceForceOk = int.TryParse(Console.ReadLine(), out int presenceForce);
            Console.Write("Presence Guard: ");
            bool presenceGuardOk = int.TryParse(Console.ReadLine(), out int presenceGuard);

            // valid input
            bool justinInputValid = justinHpOk && justinForceOk && justinGuardOk;
            bool presenceInputValid = presenceHpOk && presenceForceOk && presenceGuardOk;
            Console.WriteLine($"Justin stats valid: {justinInputValid}");
            Console.WriteLine($"Presence stats valid: {presenceInputValid}");

            int presenceMaxHp = presenceHp;
            Console.WriteLine($"[Justin]   HP:{justinHp} FRC:{justinForce} GRD:{justinGuard}");
            Console.WriteLine($"[Presence] HP:{presenceHp} FRC:{presenceForce} GRD:{presenceGuard}");

            // Justin patches himself up 
            int bandageHeal = 12;
            justinHp += bandageHeal;
            Console.WriteLine($"\nJustin uses a bandage, healing {bandageHeal}HP. HP is now {justinHp}.");

            // Damage preview  Flashlight Strike
            int strikeDamage = Math.Max(0, justinForce - presenceGuard);
            Console.WriteLine($"Flashlight Strike would deal: {strikeDamage} damage");

            // Damage preview Desperate Swing
            int desperateDamage = Math.Max(0, justinForce * 2 - presenceGuard);
            Console.WriteLine($"Desperate Swing would deal: {desperateDamage} damage");

            // Damage preview what the Presence would deal back
            int hauntDamage = Math.Max(0, presenceForce - justinGuard);
            Console.WriteLine($"If the Presence lashes back, it would deal: {hauntDamage} damage");

            // Panic Hit 
            Random rng = new Random(14);
            int roll = rng.Next(1, 101);
            bool isPanicked = roll <= 10;
            int panicDamage = strikeDamage + Convert.ToInt32(isPanicked) * strikeDamage;
            Console.WriteLine($"\nPanic roll: {roll} (panicked: {isPanicked})");
            Console.WriteLine($"If panicked, Flashlight Strike would instead deal: {panicDamage} damage");

            // Scouting report
            bool justinHitsHarder = justinForce > presenceForce;
            bool canBanishInOneHit = strikeDamage >= presenceHp;
            bool presenceCanDownJustinInOneHit = hauntDamage >= justinHp;
            bool safeMove = strikeDamage > hauntDamage && !presenceCanDownJustinInOneHit;
            bool panickedOrLethal = isPanicked || canBanishInOneHit;
            Console.WriteLine($"\nJustin hits harder than the Presence: {justinHitsHarder}");
            Console.WriteLine($"Flashlight Strike can banish the Presence in one hit: {canBanishInOneHit}");
            Console.WriteLine($"The Presence could down Justin in one hit back: {presenceCanDownJustinInOneHit}");
            Console.WriteLine($"This is a safe move for Justin: {safeMove}");
            Console.WriteLine($"This attack is panicked or lethal: {panickedOrLethal}");

            // Justin commits to the Flashlight Strike 
            presenceHp -= strikeDamage;
            Console.WriteLine($"\nJustin strikes! Presence HP: {presenceHp}/{presenceMaxHp}");

            // Result
            bool presenceBanished = presenceHp <= 0;
            int couragePoints = (presenceMaxHp - presenceHp) * 2;
            Console.WriteLine($"Presence banished: {presenceBanished}");
            Console.WriteLine($"Courage points earned: {couragePoints}");
        }
    }
}
