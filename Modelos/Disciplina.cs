using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Modelos
{
    public class Disciplina
    {
        [Key]
        public int DisciplinaID
        {
            get; set;
        }

        [Required] //chave estrangeira
        public int Codigo
        {
            get; set;
        }

        public string Materia
        {
            get; set;
        }

        [Required]
        public string Professor
        {
            get; set;
        }

        [Required]
        public string AnoLetivo
        {
            get; set;
        }

        
    }
}
