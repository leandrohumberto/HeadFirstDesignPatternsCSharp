namespace CellPhonesShowRoom.Factories
{
    interface IPhoneFactory
    {
        Products.ISmart GetSmart();
        Products.IDumb GetDumb();
    }
}
