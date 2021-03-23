namespace SOLID.DIP.Violacao
{
    public class Email
    {
        public string Texto { get; set; }

        public bool Validar() => Texto.Contains("@");
    }
}
