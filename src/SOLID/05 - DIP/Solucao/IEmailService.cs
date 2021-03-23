namespace SOLID.DIP.Solucao
{
    public interface IEmailService
    {
        void Enviar(string de, string para, string titulo, string mensagem);
    }
}
