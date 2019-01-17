using System;

namespace BuilderExamples.Builders
{
    class GuardedFluentBuilder : IFluentBuilder<GuardedFluentBuilder>
    {
        private Product _product;

        public GuardedFluentBuilder Begin()
        {
            _product = new Product();
            return this;
        }

        public GuardedFluentBuilder Engine
        {
            get
            {
                _product.Parts.Add("Engine");
                return this;
            }
        }

        public GuardedFluentBuilder SteeringWheels
        {
            get
            {
                _product.Parts.Add("Steering Wheels");
                return this;
            }
        }

        public GuardedFluentBuilder Tire()
        {
            _product.Parts.Add("Tire");
            return this;
        }

        public Product Build()
        {
            if (_product.Parts.Count < 4)
                throw new InvalidOperationException("Product doesn't have enough parts to it yet");

            if (_product.Parts.Contains("Engine") == false)
                throw new InvalidOperationException("Product must have an Engine");

            if (_product.Parts.Find((str) => str == "Tire").Length < 2)
                throw new InvalidOperationException("Product must have at least 2 Tires");

            return _product;
        }
    }
}
