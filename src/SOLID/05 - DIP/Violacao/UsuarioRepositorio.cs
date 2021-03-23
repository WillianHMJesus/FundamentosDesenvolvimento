﻿using System.Data;
using System.Data.SqlClient;

namespace SOLID.DIP.Violacao
{
    public class UsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {
            using (var connection = new SqlConnection("ConnectionString"))
            {
                using (var command = new SqlCommand("Script de Insert", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("Nome", usuario.Nome);
                    command.Parameters.AddWithValue("Email", usuario.Email.Texto);
                    command.Parameters.AddWithValue("CPF", usuario.CPF.Numero);
                    command.Parameters.AddWithValue("Senha", usuario.Senha);
                    command.Parameters.AddWithValue("DataCadastro", usuario.DataCadastro);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
