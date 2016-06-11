using av1.Models;
using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace av1.Controllers
{
    public class PedidoController : Controller
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

        public ActionResult CadastrarPedido(PedidoModel model)
        {
            try
            {
                //verificar se os dados enviados pela classe Cliente
                //nas regras de validação (nenhum erro de validação foi gerado)
                //IsValid é verdadeiro quando todas as validações mapeadas
                //em questão estão corretas, ou seja, não geraram erro
                if (ModelState.IsValid)
                {
                    Pedido c = new Pedido();
                    c.Status = model.Status;
                    c.DataPedido = model.DataPedido;

                    using (PedidoDal d = new PedidoDal())
                    {
                        d.Salvar(c); //gravando na base de dados
                    }

                    ViewBag.existe = "sim";
                    ViewBag.Nome = c.Status;
                    ViewBag.DataPedido = c.DataPedido;

                    ViewData["Mensagem"] = "Pedido cadastrado com sucesso!";

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