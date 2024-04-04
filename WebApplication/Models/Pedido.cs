using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    [Table("tb_net_pedido")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Valor { get; set; }

        public virtual Cliente Cliente { get; set; }

    }
}
