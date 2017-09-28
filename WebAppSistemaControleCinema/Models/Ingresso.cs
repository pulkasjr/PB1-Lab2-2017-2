using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaControleCinema.Models
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public int Tipo { get; set; }

        public List<Sessao> Sessoes { get; set; }
    }
}