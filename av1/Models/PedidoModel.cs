using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av1.Models
{
    public class PedidoModel
    {
        [Required(ErrorMessage = "Por favor, informe o status do pedido.")]
        [Display(Name = "Status do pedido:")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data do pedido.")]
        [Display(Name = "Data do Pedido:")]
        public DateTime DataPedido { get; set; }
    }
}
