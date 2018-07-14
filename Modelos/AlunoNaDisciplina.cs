using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelos
{
    public class AlunoNaDisciplina
    {
        [Key]
        public int AlunoNaDisciplinaID
        {
            get; set;
        }

        public int CodigoMatéria
        {
            get; set;
        }

        public int Matricula
        {
            get; set;
        }

    }
}
