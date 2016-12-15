using padoca.Models;
using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace padoca.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult CadastrarProduto(ProdutoModel model)
        {
            try
            {
                //verificar se os dados enviados pela classe Cliente
                //nas regras de validação (nenhum erro de validação foi gerado)
                //IsValid é verdadeiro quando todas as validações mapeadas
                //em questão estão corretas, ou seja, não geraram erro
                if (ModelState.IsValid)
                {
                    Produto c = new Produto();
                    c.Nome = model.Nome;
                    c.Estoque = model.Estoque;
                    c.Preco = model.Preco;

                    //Random randNum = new Random();
                    //c.ProdutoId = Convert.ToInt32(randNum.Next().ToString());

                    using (ProdutoDal d = new ProdutoDal())
                    {
                        d.Salvar(c); //gravando na base de dados
                    }

                    ViewBag.existe = "sim";
                    ViewBag.Nome = c.Nome;
                    ViewBag.Estoque = c.Estoque;
                    ViewBag.Preco = c.Preco;

                    ViewData["Mensagem"] = "Produto cadastrado com sucesso!";

                    //limpa os dados da model -> campos do formulário
                    ModelState.Clear();
                }
            }
            catch (Exception e)
            {
                ViewData["Mensagem"] = e.Message; //mensagem de erro
            }

            //redirecionamento
            return View("Cadastro"); //Página
        }

    }
}