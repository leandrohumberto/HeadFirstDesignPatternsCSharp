namespace MobilePhoneManufacturer.Builders
{
    public interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        Products.MobilePhone Phone { get; }
    }
}
