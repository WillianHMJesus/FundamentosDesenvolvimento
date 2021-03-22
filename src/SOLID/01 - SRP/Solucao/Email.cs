namespace SOLID.SRP.Solucao
{
    public class Email
    {
        public string Texto { get; set; }

        public bool Validar() => Texto.Contains("@");
    }
}
