using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdemPlus.Models
{
    [Table("ODP_USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("USU_CODIGO")]
        public int Id { get; set; }

        [Required]
        [Column("USU_NOME")]
        public string Nome { get; set; }

        [Required]
        [Column("USU_TIPO")]
        public int Tipo { get; set; }

        [Required]
        [Column("USU_SENHA")]
        public string Senha { get; set; }

        [Required]
        [Column("USU_EMAIL")]
        public string Email { get; set; }

        // FK para Empresa
        [Required]
        [Column("EMP_CODIGO")]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
