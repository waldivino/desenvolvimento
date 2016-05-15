using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace av1.Models
{
    public class ClienteModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        [Display(Name = "Nome do Cliente:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o cpf do cliente.")]
        [Display(Name = "Número do cpf:")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe o endereço do cliente.")]
        [Display(Name = "Endereço do Cliente:")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Por favor, informe o telefone do cliente.")]
        [Display(Name = "Telefone do Cliente:")]
        public string Telefone { get; set; }
    }
}
