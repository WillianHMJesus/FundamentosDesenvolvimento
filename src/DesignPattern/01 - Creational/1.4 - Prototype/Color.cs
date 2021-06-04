using System;

namespace DesignPattern.Creational.Prototype
{
    public class Color : IColorPrototype
    {
        public Color(short red, short green, short blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public short Red { get; private set; }
        public short Green { get; private set; }
        public short Blue { get; private set; }

        public IColorPrototype Clone()
        {
            Console.WriteLine("Clonando as cores RGB: ({0}, {1}, {2})", Red, Green, Blue);
            return new Color(Red, Green, Blue);
        }
    }
}
