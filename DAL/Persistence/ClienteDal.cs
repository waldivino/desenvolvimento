using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class ClienteDal : IDisposable
    {
        private Conexao Con; //null

        public ClienteDal()

        {
            Con = new Conexao(); //inicializando
        }

        public void Salvar(Cliente c)
        {
            try
            {
                Con.DbSetCliente.Add(c); //insert
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Cliente c)
        {
            try
            {
                Con.DbSetCliente.Remove(c); //delete
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public Cliente ObterPorId(int ClienteId)
        {
            try
            {
                return Con.DbSetCliente.Find(ClienteId);
            }
            catch
            {
                throw;
            }
        }

        public List<Cliente> ListarTodos()
        {
            try
            {
                return Con.DbSetCliente.ToList();
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
