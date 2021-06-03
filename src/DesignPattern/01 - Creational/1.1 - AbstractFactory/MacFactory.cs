namespace DesignPattern.Creational.AbstractFactory
{
    public class MacFactory : IOperationalSystemFactory
    {
        public ICheckBox CriarCheckbox()
        {
            return new CheckboxMac();
        }

        public IMenu CriarMenu()
        {
            return new MenuMac();
        }
    }
}
