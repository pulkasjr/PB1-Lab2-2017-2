using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaControleCinema.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public String Descricao { get; set; }

        public List <Sessao> Sessoes { get; set; }

    }
}