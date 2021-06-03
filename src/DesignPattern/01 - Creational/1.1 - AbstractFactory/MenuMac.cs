using System;

namespace DesignPattern.Creational.AbstractFactory
{
    public class MenuMac : IMenu
    {
        public void Imprimir()
        {
            Console.WriteLine("Criado um menu no mac.");
        }
    }
}
