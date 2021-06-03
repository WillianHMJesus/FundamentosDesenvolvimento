namespace DesignPattern.Creational.AbstractFactory
{
    public class WindowsFactory : IOperationalSystemFactory
    {
        public ICheckBox CriarCheckbox()
        {
            return new CheckboxWindows();
        }

        public IMenu CriarMenu()
        {
            return new MenuWindows();
        }
    }
}
