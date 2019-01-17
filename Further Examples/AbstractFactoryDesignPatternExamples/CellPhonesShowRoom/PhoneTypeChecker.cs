using CellPhonesShowRoom.Factories;
using System;

namespace CellPhonesShowRoom
{
    class PhoneTypeChecker
    {
        private Manufacturer _manufacturer;

        public PhoneTypeChecker(Manufacturer manufacturer)
        {
            _manufacturer = manufacturer;
        }

        public void CheckProducts()
        {
            IPhoneFactory factory = null;

            switch (_manufacturer)
            {
                case Manufacturer.Nokia:
                    factory = new NokiaFactory();
                    break;
                case Manufacturer.HTC:
                    factory = new HTCFactory();
                    break;
                case Manufacturer.Samsung:
                    factory = new SamsungFactory();
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0}:\nSmartphone: {1}\nDumb phone: {2}", _manufacturer.ToString(), factory.GetSmart().Name, 
                factory.GetDumb().Name);
        }
    }

    enum Manufacturer
    {
        Nokia, 
        HTC, 
        Samsung, 
    }
}
