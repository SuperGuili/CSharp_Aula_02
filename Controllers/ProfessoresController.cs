﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class ProfessoresController
    {
        //List<Professor> tabelaProfessores = new List<Professor>();
        Contexto contextoP = new Contexto();

        public void Inserir(Professor a)
        {
            //tabelaProfessores.Add(a);
            contextoP.Professores.Add(a);
            contextoP.SaveChanges();
        }

        public List<Professor> ListarTodos()
        {
            //return tabelaProfessores;
            return contextoP.Professores.ToList();
        }

        public Professor BuscarPorNome()
        {   // usando LINQ
            var professor = from p in contextoP.Professores
                        
                        select p;

            return (Professor)professor;
        }

        public Professor BuscarPorID(int idProfessor)
        {
            return contextoP.Professores.Find(idProfessor);
        }

        public void Atualizar(Professor professor)
        {
            contextoP.Entry(professor).State = System.Data.Entity.EntityState.Modified;
            contextoP.SaveChanges();
        }

        public void Excluir(int idProfessor)
        {
            Professor professor = BuscarPorID(idProfessor);
            contextoP.Professores.Remove(professor);
            contextoP.SaveChanges();
        }

        public List<Professor> BuscarPorNomeProfessor(string nome)
        {   // usando Lambda

            var professor = contextoP.Professores.Where(p => p.NomeProfessor.Contains(nome));
            return professor.ToList();
        }

    }
}
