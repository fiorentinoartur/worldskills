using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.worldskills.Domains
{

        [Table("TiposUsuario")]
        public class TiposUsuario
        {
        [Key]
        public int IdTipoUsuario { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Tipo do usuário obrigatório!")]
            public string? Titulo { get; set; }
        }
    }

