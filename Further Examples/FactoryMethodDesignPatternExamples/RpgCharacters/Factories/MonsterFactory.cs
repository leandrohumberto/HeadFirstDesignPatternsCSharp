using RpgCharacters.Products.Enemies;

namespace RpgCharacters.Factories
{
    class MonsterFactory : IMonsterFactory
    {
        public Monster Create(MonsterType type)
        {
            Monster monster = null;

            switch (type)
            {
                case MonsterType.Aquatic:
                    monster = new SeaMonster(100, 25);
                    break;
                case MonsterType.Aerial:
                    monster = new FlyingMonster(100, 35);
                    break;
                case MonsterType.Terrestrial:
                    monster = new LandMonster(100, 45);
                    break;
                default:
                    throw new System.ComponentModel.InvalidEnumArgumentException($"Invalid MonsterType option ({type})");
            }

            return monster;
        }
    }
}
