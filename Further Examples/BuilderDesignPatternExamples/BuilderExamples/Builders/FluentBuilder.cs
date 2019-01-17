namespace BuilderExamples.Builders
{
    public class FluentBuilder : IFluentBuilder<FluentBuilder>
    {
        private Product _product;

        public FluentBuilder Begin()
        {
            _product = new Product();
            return this;
        }

        public FluentBuilder Engine
        {
            get
            {
                _product.Parts.Add("Engine");
                return this;
            }
        }

        public FluentBuilder SteeringWheels
        {
            get
            {
                _product.Parts.Add("Steering steel");
                return this;
            }
        }

        public FluentBuilder Tire()
        {
            _product.Parts.Add("Tire");
            return this;
        }

        public Product Build() => _product;
    }
}
