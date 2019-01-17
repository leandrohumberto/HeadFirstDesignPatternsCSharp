namespace RpgCharacters.Products.Enemies
{
    class SeaMonster : Monster
    {
        public uint SwimmingSpeed { get; private set; }

        public SeaMonster(uint hitPoints, uint swimmingSpeed) : base(hitPoints)
        {
            SwimmingSpeed = swimmingSpeed;
        }
    }
}
