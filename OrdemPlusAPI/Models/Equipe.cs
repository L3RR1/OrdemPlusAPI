using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdemPlus.Models
{
    [Table("ODP_EQUIPE")]
    public class Equipe
    {
        [Key]
        [Column("EQP_CODIGO")]
        public int Id { get; set; }

        [Required]
        [Column("EQP_NOME")]
        public string Nome { get; set; }
    }
}
