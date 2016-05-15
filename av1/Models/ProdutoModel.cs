using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace av1.Models
{
    public class ProdutoModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        [Display(Name = "Nome do Produto:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o total de estoque.")]
        [Display(Name = "Informe o Estoque:")]
        public int Estoque { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço do produto.")]
        [Display(Name = "Informe o Preço:")]
        public decimal Preco { get; set; }
    }
}
