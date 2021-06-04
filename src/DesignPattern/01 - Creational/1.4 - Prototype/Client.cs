namespace DesignPattern.Creational.Prototype
{
    public class Client
    {
        private readonly IColorPrototype _property;

        public Client()
        {
            _property = new Color(128, 211, 128);
        }

        public void Execute()
        {
            var clone = _property.Clone();
        }
    }
}
