using System;
using System.Collections.Generic;
using System.Text;

namespace Humaniza.Models
{
    public class Profissionais 
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

        protected string Telefone;
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }

        protected string Senha;
        public string senha
        {
            get { return Senha; }
            set { Senha = value; }
        }

        public Profissionais(string nome, string email, string status, string senha, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Status = status;
            Senha = senha;
        }
    }
}
