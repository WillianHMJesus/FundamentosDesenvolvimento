using System;

namespace DesignPattern.Creational.FactoryMethod
{
    public class CheckingAccount : Account
    {
        public override void TakeOut()
        {
            Console.WriteLine("Sacando dinheiro da conta corrente.");
        }
    }
}
