using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.worldskills.Domains
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        public int IdPais { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "País obrigatório!")]
        public string? Nome { get; set; }
    }
}
