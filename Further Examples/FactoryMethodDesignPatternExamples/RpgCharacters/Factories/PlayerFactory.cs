using RpgCharacters.Products.Players;

namespace RpgCharacters.Factories
{
    class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(PlayerType type)
        {
            IPlayer player = null;

            switch (type)
            {
                case PlayerType.Knight:
                    player = new Knight(100, 0, 50);
                    break;
                case PlayerType.Wizard:
                    player = new Wizard(70, 0, 80);
                    break;
                default:
                    throw new System.ComponentModel.InvalidEnumArgumentException($"Invalid PlayerType option ({type})");
            }

            return player;
        }
    }
}
