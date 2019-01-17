using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoom.ConcreteComponents
{
    public class SuperLuxuryCar : Components.ICar
    {
        public double Cost { get; } = 1500000;

        public string Description { get; } = "Super Luxury Car";
    }
}
