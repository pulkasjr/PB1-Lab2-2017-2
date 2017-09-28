using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaControleCinema.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHorarioInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public Decimal ValorInteira { get; set; }
        public Decimal ValorMeia { get; set; }
        public Boolean  Encerrada { get; set; }

        public List <Sala> Sala{ get; set; }
        public List <Sessao> Sessoes { get; set; }
        public List <Filme> Filme { get; set; }
        public List <Ingresso> Ingressos { get; set; }


    }
}