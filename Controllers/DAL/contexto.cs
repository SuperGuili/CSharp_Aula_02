﻿using System.Data.Entity;
using Modelos;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")//base = super  do java // strConn = nome da conexao
            {
                
            }

        public DbSet<Aluno> Alunos { get; set; } //tabela alunos




    }

}