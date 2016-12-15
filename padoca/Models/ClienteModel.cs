using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace padoca.Models
{
    public class ClienteModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        [Display(Name = "Nome do Cliente:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o email.")]
        [Display(Name = "Informe o email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe o endereço do cliente.")]
        [Display(Name = "Endereço do Cliente:")]
        public string Endereco { get; set; }

    }
}
