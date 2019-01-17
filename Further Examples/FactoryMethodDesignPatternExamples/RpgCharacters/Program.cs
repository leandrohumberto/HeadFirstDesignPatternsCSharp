using RpgCharacters.Factories;
using System;

namespace RpgCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerFactory = new PlayerFactory();
            var monsterFactory = new MonsterFactory();

            var knight = playerFactory.Create(PlayerType.Knight);
            var wizard = playerFactory.Create(PlayerType.Wizard);

            Console.WriteLine("{0}:", knight.GetType().Name);
            Console.WriteLine("{0} = {1}", nameof(knight.ExperiencePoints), knight.ExperiencePoints);
            Console.WriteLine("{0} = {1}", nameof(knight.HitPoints), knight.HitPoints);
            Console.WriteLine("{0} = {1}", nameof(knight.Gold), knight.Gold);
            Console.WriteLine();

            Console.WriteLine("{0}:", wizard.GetType().Name);
            Console.WriteLine("{0} = {1}", nameof(wizard.ExperiencePoints), wizard.ExperiencePoints);
            Console.WriteLine("{0} = {1}", nameof(wizard.HitPoints), wizard.HitPoints);
            Console.WriteLine("{0} = {1}", nameof(wizard.Gold), wizard.Gold);
            Console.WriteLine();

            var aerialMonster = monsterFactory.Create(MonsterType.Aerial);
            var terrestrialMonster = monsterFactory.Create(MonsterType.Terrestrial);
            var aquaticMonster = monsterFactory.Create(MonsterType.Aquatic);

            Console.WriteLine("{0}:", aerialMonster.GetType().Name);
            Console.WriteLine("{0} = {1}", nameof(aerialMonster.HitPoints), aerialMonster.HitPoints);
            Console.WriteLine();

            Console.WriteLine("{0}:", terrestrialMonster.GetType().Name);
            Console.WriteLine("{0} = {1}", nameof(terrestrialMonster.HitPoints), terrestrialMonster.HitPoints);
            Console.WriteLine();

            Console.WriteLine("{0}:", aquaticMonster.GetType().Name);
            Console.WriteLine("{0} = {1}", nameof(aquaticMonster.HitPoints), aquaticMonster.HitPoints);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
