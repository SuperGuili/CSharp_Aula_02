using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class DisciplinasController
    {
        Contexto contextoD = new Contexto();

        public void Inserir(Disciplina a)
        {
            contextoD.Disciplinas.Add(a);
            contextoD.SaveChanges();
        }

        public List<Disciplina> ListarTodos()
        {
            return contextoD.Disciplinas.ToList();
        }

        public void ExcluirDisciplina(int a)
        {
         
        }

        public Disciplina BuscarPorID(int idDisciplina)
        {
            return contextoD.Disciplinas.Find(idDisciplina);
        }
    }
}
