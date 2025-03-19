using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdemPlus.Models
{
    [Table("ODP_FUNCIONARIO")]
    public class Funcionario
    {
        [Key]
        [Column("FUN_CODIGO")]
        public int Id { get; set; }

        [Required]
        [Column("FUN_NOME")]
        public string Nome { get; set; }

        [Column("FUN_TELEFONE")]
        public string Telefone { get; set; }

        [Column("FUN_RG")]
        public string RG { get; set; }
    }
}
