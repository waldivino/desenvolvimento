using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av1.Models
{
    class PedidoModel
    {
        [Required(ErrorMessage = "Por favor, informe o status do pedido.")]
        [Display(Name = "Nome do Produto:")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data do pedido.")]
        [Display(Name = "Nome do Produto:")]
        public DateTime DataPedido { get; set; }
    }
}
