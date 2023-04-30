﻿using Entidade.Base;

namespace Entidade
{
    public class Usuario : BaseEntity
    {
        public Usuario(string email, string password, string nome, DateTime dtNascimento)
        {
            Email = email;
            Password = password;
            Nome = nome;
            DtNascimento = dtNascimento;

            ListasUsuario = new List<ListaDeTarefas>();
        }

        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime DtCriacao { get; private set; }
        public DateTime DtNascimento { get; private set; }
        public string Nome { get; private set; }
        public List<ListaDeTarefas> ListasUsuario { get; private set; }

    }
}
