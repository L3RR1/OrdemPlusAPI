using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdemPlus.Models
{
    [Table("ODP_EMPRESA")]
    public class Empresa
    {
        [Key]
        [Column("EMP_CODIGO")]
        public int Id { get; set; }

        [Required]
        [Column("EMP_NOME")]
        public string Nome { get; set; }

        [Required]
        [Column("EMP_STATUS")]
        public bool Status { get; set; }

        [Required]
        [Column("EMP_DATA_CRIACAO")]
        public DateTime DataCriacao { get; set; }
    }
}
