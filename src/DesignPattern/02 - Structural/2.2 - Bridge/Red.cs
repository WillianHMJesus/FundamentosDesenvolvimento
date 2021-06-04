using System;

namespace DesignPattern.Structural.Bridge
{
    public class Red : Color
    {
        public override void Operation()
        {
            Console.WriteLine("Implementa operação da cor vermelha.");
        }
    }
}
