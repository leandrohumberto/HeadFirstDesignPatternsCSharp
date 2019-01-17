namespace RpgCharacters.Products.Enemies
{
    class LandMonster : Monster
    {
        public uint RunningSpeed { get; private set; }

        public LandMonster(uint hitPoints, uint runningSpeed) : base(hitPoints)
        {
            RunningSpeed = runningSpeed;
        }
    }
}
