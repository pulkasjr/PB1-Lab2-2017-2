using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppSistemaControleCinema.Models
{
    public class CinemaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CinemaContext() : base("name=CinemaContext")
        {
        }

        public System.Data.Entity.DbSet<WebAppSistemaControleCinema.Models.Sessao> Sessao { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaControleCinema.Models.Ator> Ators { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaControleCinema.Models.Ingresso> Ingressoes { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaControleCinema.Models.Sala> Salas { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaControleCinema.Models.Filme> Filmes { get; set; }
    }
}
