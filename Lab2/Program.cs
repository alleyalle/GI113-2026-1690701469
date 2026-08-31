/*
 * Student ID : 1690701469
 * Name       : natchanun kosaiyaseth
 * Section    : 129B
 * No.        : 0
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string bossName = "Mom";
            char rank = 'A';
            int level = 99;
            int maxHp = 5000;
            int currentHp = 250;
            float attackPower = 42.5f;
            double critMultiplier = 5.55;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercentage}%");

            Console.WriteLine();
            Console.WriteLine($"{bossName} takes 50 damage!");

            currentHp -= 50;

            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            int newHpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {newHpPercentage}%");

           
        }
    }
}