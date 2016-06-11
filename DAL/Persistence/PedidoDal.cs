using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class PedidoDal
    {
        private Conexao Con; //null

        public PedidoDal()

        {
            Con = new Conexao(); //inicializando
        }

        public void Salvar(Pedido p)
        {
            try
            {
                Con.DbSetPedido.Add(p); //insert
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Pedido p)
        {
            try
            {
                Con.DbSetPedido.Remove(p); //delete
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public Pedido ObterPorId(int PedidoId)
        {
            try
            {
                return Con.DbSetPedido.Find(PedidoId);
            }
            catch
            {
                throw;
            }
        }

        public List<Pedido> ListarTodos()
        {
            try
            {
                return Con.DbSetPedido.ToList();
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
