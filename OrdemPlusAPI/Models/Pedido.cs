using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdemPlus.Models
{
    [Table("ODP_PEDIDO")]
    public class Pedido
    {
        [Key]
        [Column("PED_CODIGO")]
        public int Id { get; set; }

        [Required]
        [Column("PED_DATA")]
        public DateTime Data { get; set; }

        [Column("PED_OBSERVACAO")]
        public string Observacao { get; set; }

        // FK para Servico
        [Required]
        [Column("SRV_CODIGO")]
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }

        // FK para Equipe
        [Required]
        [Column("EQP_CODIGO")]
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }
    }
}
