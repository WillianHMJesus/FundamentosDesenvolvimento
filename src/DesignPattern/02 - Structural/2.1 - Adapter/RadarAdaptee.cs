namespace DesignPattern.Structural.Adapter
{
    public class RadarAdaptee
    {
        private readonly IRadarExternalService _radarExternalService;

        public RadarAdaptee(IRadarExternalService radarExternalService)
        {
            _radarExternalService = radarExternalService;
        }

        public void AddVelocityInKilometers(float kilometers)
        {
            var miles = (float)(kilometers / 1.60934);
            _radarExternalService.Addvelocity(miles);
        }
    }
}
