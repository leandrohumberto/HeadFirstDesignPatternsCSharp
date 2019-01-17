using CarShowRoom.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShowRoom.Components;

namespace CarShowRoom.ConcreteDecorators
{
    public class ExtremeSportsAccessories : CarAccessoriesDecorator
    {
        public override string Description
        {
            get
            {
                return $"{base.Description}, Extreme Sport Accessories";
            }
        }

        public override double Cost
        {
            get
            {
                return base.Cost + 25000;
            }
        }

        public ExtremeSportsAccessories(ICar car) : base(car)
        {
        }
    }
}
