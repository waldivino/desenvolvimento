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
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {

            return View();
        }

        //Método para receber o submit POST do formulário da página
        [HttpPost] //recebe um envio de dados de um form do tipo POST (submit)
        public ActionResult CadastrarCliente(ClienteModel model)
        {
            try
            {
                //verificar se os dados enviados pela classe Cliente
                //nas regras de validação (nenhum erro de validação foi gerado)
                //IsValid é verdadeiro quando todas as validações mapeadas
                //em questão estão corretas, ou seja, não geraram erro
                if (ModelState.IsValid)
                {
                    Cliente c = new Cliente();
                    c.Nome = model.Nome;
                    c.Cpf = model.Cpf;
                    c.Endereco = model.Endereco;
                    c.Telefone = model.Telefone;

                    //Random randNum = new Random();
                    //c.ClienteId = Convert.ToInt32(randNum.Next().ToString());

                    using (ClienteDal d = new ClienteDal())
                    {
                        d.Salvar(c); //gravando na base de dados
                    }

                    ViewBag.existe = "sim";
                    ViewBag.Nome = c.Nome;
                    ViewBag.Cpf = c.Cpf;
                    ViewBag.Endereco = c.Endereco;
                    ViewBag.Telefone = c.Telefone;

                    ViewData["Mensagem"] = "Cliente cadastrado com sucesso!";

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