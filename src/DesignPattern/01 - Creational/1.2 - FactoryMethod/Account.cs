namespace DesignPattern.Creational.FactoryMethod
{
    public abstract class Account
    {
        public decimal Balance { get; set; }

        public abstract void TakeOut();
    }
}
