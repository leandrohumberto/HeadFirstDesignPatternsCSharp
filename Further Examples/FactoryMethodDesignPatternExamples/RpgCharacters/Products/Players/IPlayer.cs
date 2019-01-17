namespace RpgCharacters.Products.Players
{
    interface IPlayer
    {
        int HitPoints { get; }
        int ExperiencePoints { get; }
        int Gold { get; }
    }
}
