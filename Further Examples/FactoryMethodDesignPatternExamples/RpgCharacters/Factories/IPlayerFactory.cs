namespace RpgCharacters.Factories
{
    interface IPlayerFactory
    {
        Products.Players.IPlayer Create(PlayerType type);
    }

    enum PlayerType
    {
        Knight,
        Wizard,
    }
}
