namespace RpgCharacters.Factories
{
    interface IMonsterFactory
    {
        Products.Enemies.Monster Create(MonsterType type);
    }

    enum MonsterType
    {
        Aquatic,
        Aerial,
        Terrestrial,
    }
}
