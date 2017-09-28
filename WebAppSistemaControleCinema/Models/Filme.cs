using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaControleCinema.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public String Titulo { get; set; }
        public Decimal Duracao { get; set; }

        public List <Ator> Atores { get; set; }
        public List <Sessao> Sessoes { get; set; }

    }
}