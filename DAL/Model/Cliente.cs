using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; //mapeamento
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCliente")]
        public int ClienteId { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("Endereco")]
        public string Endereco { get; set; }

    }
}
