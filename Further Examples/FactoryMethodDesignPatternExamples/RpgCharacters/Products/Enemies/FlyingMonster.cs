namespace RpgCharacters.Products.Enemies
{
    class FlyingMonster : Monster
    {
        public uint AirSpeed { get; private set; }

        public FlyingMonster(uint hitPoints, uint airSpeed) : base(hitPoints)
        {
            AirSpeed = airSpeed;
        }
    }
}
