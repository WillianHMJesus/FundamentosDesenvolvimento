namespace DesignPattern.Creational.FactoryMethod
{
    public class SavingsAccountCreator : Creator
    {
        public override Account FactoryMethod()
        {
            return new SavingsAccount();
        }
    }
}
