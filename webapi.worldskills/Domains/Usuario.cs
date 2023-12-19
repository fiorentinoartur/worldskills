using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.worldskills.Domains
{
    [Table("Usuário")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do usuário é obrigatório!")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Email do usuário é obrigatório!")]
        public string? Email { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        public string? Senha { get; set; }


        //referência para a entidade TiposUsuario

        [Required(ErrorMessage = "O tipo do usuário é obrigatório!")]
        public int IdTipoUsuario { get; set; }


        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TipoUsuario { get; set; }
    }
}

