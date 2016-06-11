using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; //mapeamento
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdItemPedido")]
        public int ItemPedidoID { get; set; }

        [Column("Quantidade")]
        public int Quantidade { get; set; }
    }
}
