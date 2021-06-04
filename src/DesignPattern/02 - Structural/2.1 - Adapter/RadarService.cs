namespace DesignPattern.Structural.Adapter
{
    public class RadarService : IRadarService
    {
        private readonly RadarAdaptee _adaptee;

        public RadarService(RadarAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void AddVelocity(float kilometers)
        {
            _adaptee.AddVelocityInKilometers(kilometers);
        }
    }
}
