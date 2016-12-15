using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace padoca.Models
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

        [Required(ErrorMessage = "Por favor, informe a data e hora da fornada.")]
        [Display(Name = "Data e hora da fornada:")]
        public DateTime DataHoraFornada { get; set; }
    }
}
