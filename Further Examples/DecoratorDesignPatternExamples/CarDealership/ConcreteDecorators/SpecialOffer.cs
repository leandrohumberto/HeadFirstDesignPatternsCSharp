using CarDealership.Decorators;
using CarDealership.Components;

namespace CarDealership.ConcreteDecorators
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    public class SpecialOffer : VehicleDecorator
    {
        private int _discountPercentage;

        public int DiscountPercentage
        {
            get { return _discountPercentage; }
            set { _discountPercentage = ValidateDiscountPercentage(value); }
        }

        public string Offer { get; set; }

        public override double Price
        {
            get
            {
                var newPrice = base.Price - base.Price * DiscountPercentage / 100.0;
                return System.Math.Round(newPrice, 2);
            }
        }

        public SpecialOffer(IVehicle vehicle) : base(vehicle)
        {
        }

        private int ValidateDiscountPercentage(int discount)
        {
            if (discount > 100)
            {
                return 100;
            }

            if (discount < 0)
            {
                return 0;
            }

            return discount;
        }
    }
}
