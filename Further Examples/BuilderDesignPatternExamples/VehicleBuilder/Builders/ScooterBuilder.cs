namespace VehicleBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// </summary>
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder() : this(new Vehicle("Scooter"))
        {

        }

        public ScooterBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "50 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }
    }
}
