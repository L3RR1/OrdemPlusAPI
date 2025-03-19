using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdemPlus.Models
{
    [Table("ODP_SERVICOS")]
    public class Servico
    {
        [Key]
        [Column("SRV_CODIGO")]
        public int Id { get; set; }

        [Required]
        [Column("SRV_DESCRICAO")]
        public string Descricao { get; set; }
    }
}
