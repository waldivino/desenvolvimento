using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class ProdutoDal : IDisposable
    {
        private Conexao Con; //null

        public ProdutoDal()

        {
            Con = new Conexao(); //inicializando
        }

        public void Salvar(Produto p)
        {
            try
            {
                Con.DbSetProduto.Add(p); //insert
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Produto p)
        {
            try
            {
                Con.DbSetProduto.Remove(p); //delete
                Con.SaveChanges(); //executar
            }
            catch
            {
                throw;
            }
        }

        public Produto ObterPorId(int ProdutoId)
        {
            try
            {
                return Con.DbSetProduto.Find(ProdutoId);
            }
            catch
            {
                throw;
            }
        }

        public List<Produto> ListarTodos()
        {
            try
            {
                return Con.DbSetProduto.ToList();
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
