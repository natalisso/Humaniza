using System;
using System.Collections.Generic;
using System.Text;

namespace Humaniza.Models
{
    public class Gravidas
    {
        protected string Nome;
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        protected string Status;
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }

        protected string Email;
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        protected string Senha;
        public string senha
        {
            get { return Senha; }
            set { Senha = value; }
        }

        public Gravidas(string nome, string email, string status, string senha)
        {
            Nome = nome;
            Email = email;
            Status = status;
            Senha = senha;
        }
    }
}
