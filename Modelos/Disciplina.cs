using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Disciplina
    {
        [Key]
        public int DisciplinaID { get; set; }

        public string Materia
        {
            get; set;
        }

        [Required]
        public int Codigo
        {
            get; set;
        }

    }
}
