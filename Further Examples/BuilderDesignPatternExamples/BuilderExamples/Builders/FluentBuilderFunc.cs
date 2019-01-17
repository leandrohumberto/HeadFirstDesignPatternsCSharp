using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExamples.Builders
{
    public class FluentBuilderFunc : IFluentBuilder<FluentBuilderFunc>
    {
        private List<Func<Product, Product>> _steps = new List<Func<Product, Product>>();

        public FluentBuilderFunc Begin()
        {
            _steps.Clear();
            return this;
        }

        public FluentBuilderFunc Engine
        {
            get
            {
                _steps.Add(p =>
                {
                    p.Parts.Add("Engine");
                    return p;
                });
                return this;
            }
        }

        public FluentBuilderFunc SteeringWheels
        {
            get
            {
                _steps.Add(p =>
                {
                    p.Parts.Add("Steering Wheel");
                    return p;
                });
                return this;
            }
        }

        public FluentBuilderFunc Tire()
        {
            _steps.Add(p =>
            {
                p.Parts.Add("Tire");
                return p;
            });
            return this;
        }

        public Product Build()
        {
            var working = new Product();

            foreach (var step in _steps)
            {
                working = step(working);
            }

            return working;
        }
    }
}
