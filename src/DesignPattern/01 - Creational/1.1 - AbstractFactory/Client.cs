namespace DesignPattern.Creational.AbstractFactory
{
    public class Client
    {
        private readonly IOperationalSystemFactory _windowsFactory;
        private readonly IOperationalSystemFactory _macFactory;

        public Client()
        {
            _windowsFactory = new WindowsFactory();
            _macFactory = new MacFactory();
        }

        public void Execute()
        {
            var checkboxWindows = _windowsFactory.CriarCheckbox();
            var menuWindows = _windowsFactory.CriarMenu();
            checkboxWindows.Imprimir();
            menuWindows.Imprimir();

            var checkboxMac = _macFactory.CriarCheckbox();
            var menuMac = _macFactory.CriarMenu();
            checkboxMac.Imprimir();
            menuMac.Imprimir();
        }
    }
}
