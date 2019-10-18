using DDona.Solid.ISP.Model;
using DDona.Solid.ISP.Model.Interfaces;
using System;

namespace DDona.Solid.ISP.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC npc = new NPC();
            IAttack attack = new Punch() { BaseDamagePoints = 3 };
            MainPlayer hero = new MainPlayer(attack) { DefenseQuality = 5, Dexterity = 2, Strength = 3, HitPoints = 20, Name = "Great Hero" };

            Console.WriteLine($"{npc.Talk()}");
            Console.WriteLine($"{hero.Talk()}");
            Console.WriteLine($"Hero attack base stats: {hero.BasicAttack.BaseDamagePoints}");
            Console.WriteLine($"Hero attack with dex/strength: {hero.BasicAttack.CalculateTotalDamage()}");
        }
    }
}
