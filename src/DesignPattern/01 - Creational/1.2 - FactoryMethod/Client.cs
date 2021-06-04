using System;

namespace DesignPattern.Creational.FactoryMethod
{
    public class Client
    {
        private readonly Creator _checkingAccountCreator;
        private readonly Creator _savingsAccountCreator;

        public Client()
        {
            _checkingAccountCreator = new CheckingAccountCreator();
            _savingsAccountCreator = new SavingsAccountCreator();
        }

        public void Execute()
        {
            var account = CreateAccount(AccountType.Checking);
            account.TakeOut();
        }

        public Account CreateAccount(AccountType accountType)
        {
            switch(accountType)
            {
                case AccountType.Checking:
                    return _checkingAccountCreator.FactoryMethod();
                case AccountType.Savings:
                    return _savingsAccountCreator.FactoryMethod();
                default:
                    throw new ApplicationException("Tipo de conta inválido");
            }
        }
    }
}
