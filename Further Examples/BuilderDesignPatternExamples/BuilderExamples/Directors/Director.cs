using BuilderExamples.Builders;
using System;

namespace BuilderExamples.Directors
{
    public class Director
    {
        private Lazy<Builder> _lazyBuilder = 
            new Lazy<Builder>(() => new ConcreteBuilder(), true);
        private Lazy<FluentBuilder> _fluentLazyBuilder = 
            new Lazy<FluentBuilder>(() => new FluentBuilder(), true);
        private Lazy<FluentBuilderFunc> _fluentFuncLazyBuilder = 
            new Lazy<FluentBuilderFunc>(() => new FluentBuilderFunc(), true);
        private Lazy<FluentBuilderComposeFunc> _fluentComposeFuncLazyBuilder =
            new Lazy<FluentBuilderComposeFunc>(() => new FluentBuilderComposeFunc(), true);
        private Lazy<GuardedFluentBuilder> _guardedLazyBuilder =
            new Lazy<GuardedFluentBuilder>(() => new GuardedFluentBuilder(), true);

        public Product Construct()
        {
            for (int i = 0; i < 5; i++)
            {
                _lazyBuilder.Value.BuildPart();
            }

            return _lazyBuilder.Value.Construct();
        }

        public Product ConstructFluently()
        {
            return _fluentLazyBuilder.Value.Begin()
                .Engine
                .SteeringWheels
                .Tire()
                .Tire()
                .Build();
        }

        public Product ContructFluentlyFunc()
        {
            return _fluentFuncLazyBuilder.Value.Begin()
                .Engine
                .SteeringWheels
                .Tire()
                .Tire()
                .Build();
        }

        public Product ContructFluentlyComposeFunc()
        {
            return _fluentComposeFuncLazyBuilder.Value.Begin()
                .Engine
                .SteeringWheels
                .Tire()
                .Tire()
                .Build();
        }

        public Product ContructFluentlyGuarded()
        {
            return _guardedLazyBuilder.Value.Begin()
                .Engine
                .SteeringWheels
                .Tire()
                .Tire()
                .Build();
        }
    }
}
