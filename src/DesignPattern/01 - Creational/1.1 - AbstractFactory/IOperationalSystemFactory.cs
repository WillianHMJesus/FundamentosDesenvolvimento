namespace DesignPattern.Creational.AbstractFactory
{
    public interface IOperationalSystemFactory
    {
        ICheckBox CriarCheckbox();
        IMenu CriarMenu();
    }
}
