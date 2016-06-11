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
            : base(ConfigurationManager.ConnectionStrings["infnet"].ConnectionString)
        {

        }

        public DbSet<Cliente> DbSetCliente { get; set; }
        public DbSet<Produto> DbSetProduto { get; set; }
        public DbSet<Pedido> DbSetPedido { get; set; }
        public DbSet<ItemPedido> DbSetItemPedido { get; set; }


    }
}
