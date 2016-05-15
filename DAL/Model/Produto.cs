using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; //mapeamento
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdProduto")]
        public int ProdutoId { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Estoque")]
        public int? Estoque { get; set; }

        [Column("Preco")]
        public decimal? Preco { get; set; }
    }
}
