using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hero
            Console.WriteLine("==>>> Follow me home <<<==");
            Console.WriteLine("Hero vs. Monster -- Calculate Damage");

            Console.WriteLine("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack");
            bool heroAtkOk = int.TryParse(Console.ReadLine(),out int heroAtk);
            Console.WriteLine("Hero Defense");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            //monster
            Console.WriteLine("Hero HP: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Hero Attack");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Hero Defense");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            //check for valid input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterInputValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"Hero stats valid: {heroInputValid}");
            Console.WriteLine($"Monster stats valid: {monsterInputValid}");
            Console.WriteLine($"[HERO]          HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[Monster]          HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");


            int potionHeal = 29;
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks a potion, Healing {potionHeal}HP. health is now {heroHp}.");


            // คำนวณ damage normal attack(Arithmetic + Math)
            int normalDamage = Math.Max(0, heroAtk - monDef);
             // ATK 10 DEF 5 หลังคำนวณ ATK จะไม่ได้ลดเหลือ 5
            Console.WriteLine($"Normal Attack deal: {normalDamage}  DMG");
            // คำนวณ power attack (Predence ลำดับการคำนวณ คุณ ก่อนทีจะ ลบ)
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef); // เรียบลำดับ * มาก่อน - ไม่จำเป็นต้องมี()
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");
            //คำนวณ Monster Attack
            int counterDamge = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamge} DMG");
            // คำนวณ Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101);
            // สม Cri 1 - 100
            bool isCrit = roll <= 10; // 10%
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} DMG");
        }
    }
}
