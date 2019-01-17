namespace RpgCharacters.Products.Players
{
    class Wizard : IPlayer
    {
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }
        public int HitPoints { get; private set; }

        internal Wizard(int hitPoints, int experiencePoints, int gold)
        {
            HitPoints = hitPoints;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }
    }
}
