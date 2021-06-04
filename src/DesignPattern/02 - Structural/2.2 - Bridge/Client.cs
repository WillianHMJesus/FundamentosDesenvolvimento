namespace DesignPattern.Structural.Bridge
{
    public class Client
    {
        private readonly Form _form;

        public Client(Form form)
        {
            _form = form;
        }

        public void Execute()
        {
            _form.Color = new Blue();
            _form.Operation();

            _form.Color = new Red();
            _form.Operation();
        }
    }
}
