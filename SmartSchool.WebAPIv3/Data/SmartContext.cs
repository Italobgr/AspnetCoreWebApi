using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPIv3.Models;

namespace SmartSchool.WebAPIv3.Data
{
    public class SmartContext : DbContext
    {
        
        public SmartContext(DbContextOptions<SmartContext> options) :base(options){}// transferencia de dados com o entity

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Diciplina> Diciplinas { get; set; }
        public DbSet<AlunoDiciplina> AlunoDiciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDiciplina>()
            .HasKey(AD => new {AD.AlunoId, AD.DiciplinaId});

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, "Lauro"),
                    new Professor(2, "Roberto"),
                    new Professor(3, "Ronaldo"),
                    new Professor(4, "Rodrigo"),
                    new Professor(5, "Alexandre"),
                });
            
            builder.Entity<Diciplina>()
                .HasData(new List<Diciplina>{
                    new Diciplina(1, "Matemática", 1),
                    new Diciplina(2, "Física", 2),
                    new Diciplina(3, "Português", 3),
                    new Diciplina(4, "Inglês", 4),
                    new Diciplina(5, "Programação", 5)
                });
            
            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, "Marta", "Kent", "33225555"),
                    new Aluno(2, "Paula", "Isabela", "3354288"),
                    new Aluno(3, "Laura", "Antonia", "55668899"),
                    new Aluno(4, "Luiza", "Maria", "6565659"),
                    new Aluno(5, "Lucas", "Machado", "565685415"),
                    new Aluno(6, "Pedro", "Alvares", "456454545"),
                    new Aluno(7, "Paulo", "José", "9874512")
                });

            builder.Entity<AlunoDiciplina>()
                .HasData(new List<AlunoDiciplina>() {
                    new AlunoDiciplina() {AlunoId = 1, DiciplinaId = 2 },
                    new AlunoDiciplina() {AlunoId = 1, DiciplinaId = 4 },
                    new AlunoDiciplina() {AlunoId = 1, DiciplinaId = 5 },
                    new AlunoDiciplina() {AlunoId = 2, DiciplinaId = 1 },
                    new AlunoDiciplina() {AlunoId = 2, DiciplinaId = 2 },
                    new AlunoDiciplina() {AlunoId = 2, DiciplinaId = 5 },
                    new AlunoDiciplina() {AlunoId = 3, DiciplinaId = 1 },
                    new AlunoDiciplina() {AlunoId = 3, DiciplinaId = 2 },
                    new AlunoDiciplina() {AlunoId = 3, DiciplinaId = 3 },
                    new AlunoDiciplina() {AlunoId = 4, DiciplinaId = 1 },
                    new AlunoDiciplina() {AlunoId = 4, DiciplinaId = 4 },
                    new AlunoDiciplina() {AlunoId = 4, DiciplinaId = 5 },
                    new AlunoDiciplina() {AlunoId = 5, DiciplinaId = 4 },
                    new AlunoDiciplina() {AlunoId = 5, DiciplinaId = 5 },
                    new AlunoDiciplina() {AlunoId = 6, DiciplinaId = 1 },
                    new AlunoDiciplina() {AlunoId = 6, DiciplinaId = 2 },
                    new AlunoDiciplina() {AlunoId = 6, DiciplinaId = 3 },
                    new AlunoDiciplina() {AlunoId = 6, DiciplinaId = 4 },
                    new AlunoDiciplina() {AlunoId = 7, DiciplinaId = 1 },
                    new AlunoDiciplina() {AlunoId = 7, DiciplinaId = 2 },
                    new AlunoDiciplina() {AlunoId = 7, DiciplinaId = 3 },
                    new AlunoDiciplina() {AlunoId = 7, DiciplinaId = 4 },
                    new AlunoDiciplina() {AlunoId = 7, DiciplinaId = 5 }
                });

        }
    }
}