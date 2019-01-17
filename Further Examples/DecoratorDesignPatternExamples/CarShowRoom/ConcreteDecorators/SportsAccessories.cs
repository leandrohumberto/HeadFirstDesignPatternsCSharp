using CarShowRoom.Components;
using CarShowRoom.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoom.ConcreteDecorators
{
    class SportsAccessories : CarAccessoriesDecorator
    {
        public override string Description
        {
            get
            {
                return $"{base.Description}, Sports Accessories Package";
            }
        }

        public override double Cost
        {
            get
            {
                return base.Cost + 15000;
            }
        }

        public SportsAccessories(ICar car) : base(car)
        {
        }
    }
}
