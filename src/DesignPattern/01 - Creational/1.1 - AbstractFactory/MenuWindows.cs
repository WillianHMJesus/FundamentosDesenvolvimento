using System;

namespace DesignPattern.Creational.AbstractFactory
{
    public class MenuWindows : IMenu
    {
        public void Imprimir()
        {
            Console.WriteLine("Criado um menu no windows.");
        }
    }
}
