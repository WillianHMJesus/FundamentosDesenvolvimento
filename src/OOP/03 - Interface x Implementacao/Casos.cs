namespace OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar() { }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar() { }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoInterface
    {
        private readonly IRepositorio _repositorio;

        public UsoInterface(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class UsoImplementacaoInterface
    {
        public UsoImplementacaoInterface()
        {
            var implementacao = new UsoImplementacao();
            implementacao.Processo();

            var abstracao = new UsoInterface(new Repositorio());
            abstracao.Processo();

            var abstracaoFake = new UsoInterface(new RepositorioFake());
            abstracaoFake.Processo();
        }
    }
}
