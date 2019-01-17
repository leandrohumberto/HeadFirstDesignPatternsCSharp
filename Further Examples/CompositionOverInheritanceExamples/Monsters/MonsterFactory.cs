namespace Monsters
{
    public class MonsterFactory
    {
        public enum MonsterType
        {
            Horse, // BitingKickingMonster
            Orc, // BitingKickingPunchingMonster
            Crocodile, // BitingMonster
            MikeTyson, // BitingPunchingMonster
            Cobra, // BitingSpittingMonster
            Camel, // KickingSpittingMonster
            Kangaroo, // KickingPunchingMonster
            MantisShrimp //PunchingMonster
        }

        public static Monster CreateMonster(MonsterType monsterType)
        {
            Monster monster;

            switch (monsterType)
            {
                case MonsterType.Horse:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    break;
                case MonsterType.Orc:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                case MonsterType.Crocodile:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    break;
                case MonsterType.MikeTyson:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                case MonsterType.Cobra:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Spitting, 5);
                    break;
                case MonsterType.Camel:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    monster.AddAttackType(AttackType.Spitting, 5);
                    break;
                case MonsterType.Kangaroo:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                case MonsterType.MantisShrimp:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                default:
                    throw new System.ComponentModel.InvalidEnumArgumentException($"Invalid MonsterType option ({monsterType})");
            }

            return monster;
        }
    }
}
