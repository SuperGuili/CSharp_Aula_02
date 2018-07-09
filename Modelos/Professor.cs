using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Professor
    {
        [Key]
        public int ProfessorID { get; set; }

        private string nomeProfessor;
        public string NomeProfessor
        {
            get { return nomeProfessor; }
            set { nomeProfessor = value; }
        }

        [Required]
        public string CPF
        {
            get; set;
        }

        public string EmailProfessor
        {
            get; set;
        }

        public string Formacao
        {
            get; set;
        }

        public string FoneProfessor
        {
            get; set;
        }
    }
}
