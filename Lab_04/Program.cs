/*
 * Student ID : 1690701469
 * Name       : Natchanun kosaiyaseth
 * Section    : 129B
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CardName = "Gadget Card";
            var itemName = "Anesthetic Watch";
            var itemType = "Support";
            string itemAbility = "Fires a sleeping needle that knocks out the target on hit.";
            char rarityTier = 'A';
            int level = 153;
            float itemEnergy = 350.75f;
            double itemPower = 149.65;
            bool isAwakened = true;
            double levelDouble = level;
            int powerTruncated = (int)itemPower;
            int powerRounded = Convert.ToInt32(itemPower);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"I         {CardName}        I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I              _.--._             I");
            Console.WriteLine("I            /        \\           I");
            Console.WriteLine("I           |   12  1   |          I");
            Console.WriteLine("I           |9    +    3|          I");
            Console.WriteLine("I           |    6      |          I");
            Console.WriteLine("I            \\        /           I");
            Console.WriteLine("I              '--'--'            I");
            Console.WriteLine("I                ||                I");
            Console.WriteLine($"I       {itemName} : {itemType,-14}I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I             Ability             I");
            Console.WriteLine("I                                 I");
            Console.WriteLine($"I  {itemAbility,-31}I");
            Console.WriteLine("I                                 I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I                                 I");
            Console.WriteLine($"I  LVL         : {level,-17}I");
            Console.WriteLine($"I  Rarity      : {rarityTier,-17}I");
            Console.WriteLine($"I  Power       : {itemPower,-17}I");
            Console.WriteLine($"I  Energy      : {itemEnergy,-17}I");
            Console.WriteLine($"I  Awaken      : {isAwakened,-17}I");
            Console.WriteLine("I                                 I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I             Log                 I");
            Console.WriteLine("I                                 I");
            Console.WriteLine($"I  Lv as double  : {levelDouble,-15}I");
            Console.WriteLine($"I  Power (cast)  : {powerTruncated,-15}I");
            Console.WriteLine($"I  Power Convert : {powerRounded,-15}I");
            Console.WriteLine("I                                 I");
            Console.WriteLine("-----------------------------------");
        }
    }
}