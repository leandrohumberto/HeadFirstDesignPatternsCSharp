using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.ConcreteComponents
{
    public class ThinCrust : Components.Pizza
    {
        public override double Price { get; } = 200;
    }
}
