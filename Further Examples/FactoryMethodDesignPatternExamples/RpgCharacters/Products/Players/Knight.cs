namespace RpgCharacters.Products.Players
{
    class Knight : IPlayer
    {
        public int HitPoints { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        internal Knight(int hitPoints, int experiencePoints, int gold)
        {
            HitPoints = hitPoints;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }
    }
}
