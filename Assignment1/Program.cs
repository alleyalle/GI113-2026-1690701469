/*
* Student ID : 1690701469
* Name       : Natchanun kosaiyaseth
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/


namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //game name
            const string Gametitle = "NEON VORTEX";

            //Main characther Information

            var assasinName = "Takeko";
            var assasinType = "A";
            string charactherHistory = "A female warrior desended from the yakuza tanukicrace. Takeko used a veriety of weapons at a young age. her favorite weapon is katana sword";
            int expertiseLevel = 4;
            int maxexpertiseLevel = 10;
            float criticalDamagebyKatana = 0.55f;
            double skillcomboDamage = 75.5;
            bool isPlayable = true;

            int skillcomboDamageTruncated = (int)skillcomboDamage;
            int skillcomboDamageRounded = Convert.ToInt32(skillcomboDamage);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" <___________________>");
            Console.WriteLine(" //-----------------\\");
            Console.WriteLine($">>>>  {Gametitle}  <<<<");
            Console.WriteLine(" \\-----------------//");
            Console.WriteLine(" <___________________>");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=====================");
            Console.WriteLine("    >>---------<<");
            Console.WriteLine("  >>-------------<<");
            Console.WriteLine(">>-----------------<<");
            Console.WriteLine($">>>Your Assasin is  {assasinName} <<<");
            Console.WriteLine("> Your Assasin history <");
            Console.WriteLine($"{charactherHistory}");
            Console.WriteLine(">>-----------------<<");
            Console.WriteLine("  >>-------------<<");
            Console.WriteLine("    >>---------<<");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   =============");
            Console.WriteLine($"<< Assasin type {assasinType} >>");
            Console.WriteLine("");
            Console.WriteLine($" Your Expertise Level {expertiseLevel} ");
            Console.WriteLine($" Your CritDamage by weapon {criticalDamagebyKatana} ");
            Console.WriteLine($" Your skill combo damage is {skillcomboDamage} ");
            Console.WriteLine($" Characther status {isPlayable}");
            Console.WriteLine("   =============");

            Console.ForegroundColor = ConsoleColor.Yellow;

            double expertiseLevelAsDouble = expertiseLevel;
            Console.WriteLine($">> Level as double (implicit) {expertiseLevelAsDouble} <<");

            Console.WriteLine($"Skill combo damage cast (truncates) {skillcomboDamageTruncated}");
            Console.WriteLine($"Skill combo damage Convert (rounds) {skillcomboDamageRounded}");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\\-------------------------/");
        }
    }
}
