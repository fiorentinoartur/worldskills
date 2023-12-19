using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.worldskills.Domains
{


    [Table("Ranking")]
    public class Ranking
    {

        [Key]
        public int IdRanking { get; set; }

        [Column(TypeName = "INT")]
        [Required(ErrorMessage = "Os Pontos é obrigatório!")]
        public int? Pontos { get; set; }

        //referência para a entidade Medalha

        [Required(ErrorMessage = "Medalha é obrigatório!")]
        public int IdMedalha { get; set; }


        [ForeignKey("IdMedalha")]
        public Medalha? Medalha { get; set; }


        //referência para a entidade Pais

        [Required(ErrorMessage = "País é obrigatório!")]
        public int IdPais { get; set; }


        [ForeignKey("IdPais")]
        public Pais? Pais { get; set; }
        //referência para a entidade Session

        [Required(ErrorMessage = "A session é obrigatório!")]
        public int IdSession { get; set; }


        [ForeignKey("IdSession")]
        public Session? Session { get; set; }


        //referência para a entidade TiposUsuario

        [Required(ErrorMessage = "Competidor é obrigatório!")]
        public int IdCompetidor { get; set; }


        [ForeignKey("IdCompetidor")]
        public Competidor? Competidor { get; set; }
    }
}
