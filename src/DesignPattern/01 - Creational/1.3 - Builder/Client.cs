namespace DesignPattern.Creational.Builder
{
    public class Client
    {
        private readonly ConstructionBuilder _builder;

        public Client()
        {
            _builder = new BlockHouseBuilder();
        }

        public void Execute()
        {
            _builder.BuildWall(5);
            _builder.BuildDoor(2);
            _builder.BuildWindow(3);
            _builder.BuildGarage(true);
        }
    }
}
