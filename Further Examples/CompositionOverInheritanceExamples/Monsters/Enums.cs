namespace Monsters
{
    public enum AttackType
    {
        Biting,
        Kicking,
        Punching,
        Spitting,
    }

    enum MonsterType
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
}
