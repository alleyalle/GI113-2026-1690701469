namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;





            Console.WriteLine("=== KIRIN SAVE CI=ONVERTER ===");
            Console.WriteLine($"NAME: {bossName}"
                $"\nRank: {rank}" +
                $"\nLEVEL: {level} / {MaxLevel}" +
                $"\nHp: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackPower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");

            Console.WriteLine("\n---implicit conversion: HP as double ---");
            double currentHpDouble = currentHp;
            Console.WriteLine($"/"

        }
    }
}
