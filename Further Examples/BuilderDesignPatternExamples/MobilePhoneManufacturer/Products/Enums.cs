namespace MobilePhoneManufacturer.Products
{
    public enum ScreenType
    {
        TouchCapacitive,
        TouchResistive,
        NonTouch,
    }

    public enum Battery
    {
        _1000mAh,
        _1500mAh,
        _2000mAh,
    }

    public enum OperatingSystem
    {
        Android,
        WindowsMobile,
        WindowsPhone,
        Symbian,
    }

    public enum Stylus
    {
        Yes,
        No,
    }

    static class Extenders
    {
        public static string ToFormattedString(this Battery battery)
        {
            string text;

            switch (battery)
            {
                case Battery._1000mAh:
                    text = "1,000 mAh";
                    break;
                case Battery._1500mAh:
                    text = "1,500 mAh";
                    break;
                case Battery._2000mAh:
                    text = "2,000 mAh";
                    break;
                default:
                    text = battery.ToString();
                    break;
            }

            return text;
        }
    }
}
