namespace RpgCharacters.Products.Enemies
{
    abstract class Monster
    {
        public uint HitPoints { get; private set; }

        public Monster(uint hitPoints)
        {
            HitPoints = hitPoints;
        }
    }
}
