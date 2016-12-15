using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Configuration;
using DAL.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    class Conexao : DbContext
    {

        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["av1"].ConnectionString)
        {

        }

        public DbSet<Cliente> DbSetCliente { get; set; }
        public DbSet<Produto> DbSetProduto { get; set; }


    }
}
