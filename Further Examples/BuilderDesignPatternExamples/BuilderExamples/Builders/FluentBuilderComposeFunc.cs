using System;

namespace BuilderExamples.Builders
{
    public class FluentBuilderComposeFunc : IFluentBuilder<FluentBuilderComposeFunc>
    {
        private Func<Product, Product> _func = null;

        public FluentBuilderComposeFunc Begin()
        {
            _func = (ignore) => new Product();
            return this;
        }

        public FluentBuilderComposeFunc Engine
        {
            get
            {
                _func = FnUtils.Compose(_func, p =>
                {
                    p.Parts.Add("Engine");
                    return p;
                });
                return this;
            }
        }

        public FluentBuilderComposeFunc SteeringWheels
        {
            get
            {
                _func = FnUtils.Compose(_func, p =>
                {
                    p.Parts.Add("Steering Wheel");
                    return p;
                });
                return this;
            }
        }

        public FluentBuilderComposeFunc Tire()
        {
            _func = FnUtils.Compose(_func, p =>
            {
                p.Parts.Add("Tire");
                return p;
            });
            return this;
        }

        public Product Build()
        {
            return _func(null);
        }

        private static class FnUtils
        {
            public static Func<A, C> Compose<A, B, C>(Func<A,B> f1, Func<B, C> f2)
            {
                return (a) => f2(f1(a));
            }
        }
    }
}
