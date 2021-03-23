using System;

namespace SOLID.ISP.Violacao
{
    public class LogRepositorio : IRepositorio
    {
        public void Adicionar()
        {
            //Adiciona o log no banco
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
