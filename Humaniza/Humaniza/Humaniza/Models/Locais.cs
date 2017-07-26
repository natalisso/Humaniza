using System;
using System.Collections.Generic;
using System.Text;

namespace Humaniza.Models
{
    class Locais
    {
        protected string Nome;
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        protected string Endereco;
        public string endereco
        {
            get { return Endereco; }
            set { Endereco = value; }
        }

        protected string Informacao;
        public string informacao
        {
            get { return Informacao; }
            set { Informacao = value; }
        }

        protected string Telefone;
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }

        protected string Email;
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }


    }
}
