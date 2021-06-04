namespace DesignPattern.Structural.Bridge
{
    public class Form
    {
        public Color Color { get; set; }

        public virtual void Operation()
        {
            Color.Operation();
        }
    }
}
