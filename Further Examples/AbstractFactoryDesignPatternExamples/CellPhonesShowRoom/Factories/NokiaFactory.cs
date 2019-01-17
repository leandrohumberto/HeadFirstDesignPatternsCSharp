using CellPhonesShowRoom.Products;

namespace CellPhonesShowRoom.Factories
{
    class NokiaFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Asha();
        }

        public ISmart GetSmart()
        {
            return new Lumia();
        }
    }
}
