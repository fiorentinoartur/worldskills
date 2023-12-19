using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.worldskills.Domains
{
    [Table("Medalha")]
    public class Medalha
    {
        [Key]
        public int IdTipoMedalha { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Medalha obrigatório!")]
        public string? TipoMedalha { get; set; }
    }
}
