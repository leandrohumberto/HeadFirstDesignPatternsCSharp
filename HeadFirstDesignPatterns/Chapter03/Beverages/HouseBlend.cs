using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.Beverages
{
    public class HouseBlend : Beverage
    {
        public override string Description { get; } = "House Blend Coffee";

        public override double Cost
        {
            get { return .89; }
        }

        public HouseBlend(BeverageSize size) : base(size)
        {

        }
    }
}
