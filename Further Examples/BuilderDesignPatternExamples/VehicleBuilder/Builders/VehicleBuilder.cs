namespace VehicleBuilder
{
    public abstract class VehicleBuilder
    {
        private Vehicle _vehicle;

        public VehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle Vehicle => _vehicle;

        public abstract void BuildFrame();

        public abstract void BuildEngine();

        public abstract void BuildWheels();

        public abstract void BuildDoors();
    }
}
