using System;

namespace SOLID.DIP.Solucao
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IEmailService _emailService;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IEmailService emailService, IUsuarioRepositorio usuarioRepositorio)
        {
            _emailService = emailService;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public string Adicionar(Usuario usuario)
        {
            if (!usuario.Validar())
                throw new Exception("Erro na validação do usuário.");

            _usuarioRepositorio.Adicionar(usuario);

            _emailService.Enviar("nãoReponder@empresa.com", usuario.Email.Texto, "Bem vindo.", "Parabéns! Seu cadastro foi realizado com sucesso.");

            return "Usuário cadastrado com sucesso.";
        }
    }
}
