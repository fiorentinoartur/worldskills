using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.worldskills.Domains
{
    [Table("Competidor")]
    public class Competidor
    {
        [Key]
        public int IdCompetidor { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome Competidor obrigatório!")]
        public string? Nome { get; set; }
    }
}
