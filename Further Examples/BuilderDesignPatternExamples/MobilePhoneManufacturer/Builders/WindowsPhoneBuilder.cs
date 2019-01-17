using MobilePhoneManufacturer.Products;

namespace MobilePhoneManufacturer.Builders
{
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        private MobilePhone _phone;

        public WindowsPhoneBuilder()
        {
            _phone = new MobilePhone("Windows Phone");
        }

        public MobilePhone Phone => _phone;

        public void BuildBattery()
        {
            _phone.PhoneBattery = Battery._2000mAh;
        }

        public void BuildOS()
        {
            _phone.PhoneOS = Products.OperatingSystem.WindowsPhone;
        }

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenType.TouchCapacitive;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = Stylus.No;
        }
    }
}
