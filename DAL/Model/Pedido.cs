using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; //mapeamento
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idPedido")]
        public int PedidoID { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("DataPedido")]
        public DateTime DataPedido { get; set; }
    }
}
