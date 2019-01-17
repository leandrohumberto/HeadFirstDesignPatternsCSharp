using System;

namespace Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

            Console.WriteLine("Crocodile:");
            Console.WriteLine("Can bite? {0}", crocodile.CanBite);
            Console.WriteLine("Can kick? {0}", crocodile.CanKick);
            Console.WriteLine("Can punch? {0}", crocodile.CanPunch);
            Console.WriteLine("");

            Monster horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Console.WriteLine("Horse:");
            Console.WriteLine("Can bite? {0}", horse.CanBite);
            Console.WriteLine("Can kick? {0}", horse.CanKick);
            Console.WriteLine("Can punch? {0}", horse.CanPunch);
            Console.ReadKey();
        }
    }
}
