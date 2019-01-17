using MobilePhoneManufacturer.Products;

namespace MobilePhoneManufacturer.Builders
{
    public class AndroidPhoneBuilder : IPhoneBuilder
    {
        private MobilePhone _phone;

        public MobilePhone Phone => _phone;

        public AndroidPhoneBuilder()
        {
            _phone = new MobilePhone("Android Phone");
        }

        public void BuildBattery()
        {
            _phone.PhoneBattery = Battery._1500mAh;
        }

        public void BuildOS()
        {
            _phone.PhoneOS = OperatingSystem.Android;
        }

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenType.TouchResistive;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = Stylus.Yes;
        }
    }
}
