using System;
using System.Collections.Generic;
using System.Text;

namespace Humaniza.Models
{
    class Noticias
    {
        protected string Titulo;
        public string titulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }

        protected string CorpoDeTexto;
        public string corpodetexto
        {
            get { return CorpoDeTexto; }
            set { CorpoDeTexto = value; }
        }

        public Noticias(string titulo, string corpo)
        {
            Titulo = titulo;
            CorpoDeTexto = corpo;
        }

    }
}
