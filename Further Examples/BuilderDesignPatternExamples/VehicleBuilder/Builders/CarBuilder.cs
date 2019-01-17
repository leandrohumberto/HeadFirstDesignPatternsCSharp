namespace VehicleBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder() : this(new Vehicle("Car"))
        {

        }

        public CarBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "Car Frame";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "4";
        }
    }
}
