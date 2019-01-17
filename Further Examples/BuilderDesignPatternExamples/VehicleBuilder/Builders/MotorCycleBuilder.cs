namespace VehicleBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder() : this(new Vehicle("MotorCycle"))
        {

        }

        public MotorCycleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }
    }
}
