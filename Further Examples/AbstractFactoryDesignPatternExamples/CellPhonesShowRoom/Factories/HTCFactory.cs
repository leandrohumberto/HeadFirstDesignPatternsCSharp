using CellPhonesShowRoom.Products;

namespace CellPhonesShowRoom.Factories
{
    class HTCFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Genie();
        }

        public ISmart GetSmart()
        {
            return new Titan();
        }
    }
}
