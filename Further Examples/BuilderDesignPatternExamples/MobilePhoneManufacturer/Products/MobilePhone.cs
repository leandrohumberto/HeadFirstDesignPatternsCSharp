namespace MobilePhoneManufacturer.Products
{
    public class MobilePhone
    {
        public string PhoneName { get; set; }

        public ScreenType PhoneScreen { get; set; }

        public Battery PhoneBattery { get; set; }

        public OperatingSystem PhoneOS { get; set; }

        public Stylus PhoneStylus { get; set; }

        public MobilePhone(string name)
        {
            PhoneName = name;
        }

        public override string ToString()
        {
            return $"Name: {PhoneName}\nScreen: {PhoneScreen}\nBattery: {PhoneBattery.ToFormattedString()}\nOS{PhoneOS}\nStylus: {PhoneStylus}";
        }
    }
}
