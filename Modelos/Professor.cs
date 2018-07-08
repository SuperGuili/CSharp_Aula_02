using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Professor
    {
        [Key]
        public int ProfessorID { get; set; }


        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [Required]
        public string Cpf
        {
            get; set;
        }

    }
}
