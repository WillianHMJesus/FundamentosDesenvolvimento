using System;

namespace DesignPattern.Creational.AbstractFactory
{
    public class CheckboxMac : ICheckBox
    {
        public void Imprimir()
        {
            Console.WriteLine("Criado um checkbox no mac.");
        }
    }
}
