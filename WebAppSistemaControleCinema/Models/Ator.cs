using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaControleCinema.Models
{
    public class Ator
    {
        public int AtorId { get; set; }
        public String Nome { get; set; }

        public List <Filme> Filmes { get; set; }


    }
}