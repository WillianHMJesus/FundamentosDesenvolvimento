namespace DesignPattern.Creational.FactoryMethod
{
    public class CheckingAccountCreator : Creator
    {
        public override Account FactoryMethod()
        {
            return new CheckingAccount();
        }
    }
}
