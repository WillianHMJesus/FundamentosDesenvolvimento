using System;

namespace DesignPattern.Creational.AbstractFactory
{
    public class CheckboxWindows : ICheckBox
    {
        public void Imprimir()
        {
            Console.WriteLine("Criado um checkbox no windows.");
        }
    }
}
