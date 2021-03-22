using System;

namespace SOLID.SRP.Solucao
{
    public class UsuarioService
    {
        public string Adicionar(Usuario usuario)
        {
            if (!usuario.Validar())
                throw new Exception("Erro na validação do usuário.");

            var usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Adicionar(usuario);

            EmailService.Enviar("nãoReponder@empresa.com", usuario.Email.Texto, "Bem vindo.", "Parabéns! Seu cadastro foi realizado com sucesso.");

            return "Usuário cadastrado com sucesso.";
        }
    }
}
