using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    class ItemPedidoDal
    {
        private Conexao Con; //null

        public ItemPedidoDal()

        {
            Con = new Conexao(); //inicializando
        }

        public void Salvar(ItemPedido p)
        {
            try
            {
                Con.DbSetItemPedido.Add(p); //insert
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(ItemPedido p)
        {
            try
            {
                Con.DbSetItemPedido.Remove(p); //delete
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public ItemPedido ObterPorId(int itemPedidoID)
        {
            try
            {
                return Con.DbSetItemPedido.Find(itemPedidoID);
            }
            catch
            {
                throw;
            }
        }

        public List<ItemPedido> ListarTodos()
        {
            try
            {
                return Con.DbSetItemPedido.ToList();
            }

            catch
            {
                throw;
            }
        }

        //Método para destruir a conexão instanciada
        public void Dispose()
        {
            Con.Dispose(); //liberando a conexão
        }
    }
}
