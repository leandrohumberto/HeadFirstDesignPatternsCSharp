using CellPhonesShowRoom.Products;

namespace CellPhonesShowRoom.Factories
{
    class SamsungFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Primo();
        }

        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }
    }
}
