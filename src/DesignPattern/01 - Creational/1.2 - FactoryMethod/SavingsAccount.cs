using System;

namespace DesignPattern.Creational.FactoryMethod
{
    public class SavingsAccount : Account
    {
        public override void TakeOut()
        {
            Console.WriteLine("Sacando dinheiro da conta poupança.");
        }
    }
}
