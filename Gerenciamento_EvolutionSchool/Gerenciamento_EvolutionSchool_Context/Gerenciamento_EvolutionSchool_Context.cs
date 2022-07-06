using Gerenciamento_EvolutionSchool.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerenciamento_EvolutionSchool.Context
{
    public class Gerenciamento_EvolutionSchool_Context : DbContext
    {
        public Gerenciamento_EvolutionSchool_Context(DbContextOptions<Gerenciamento_EvolutionSchool_Context> options) : base(options)
        { }

        public DbSet<Turma> Turma { get; set; }

        public DbSet<Aluno> Aluno { get;  set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)


        {
            modelBuilder.Entity<Turma>().ToTable("Turma");
            modelBuilder.Entity<Aluno>().ToTable("Aluno");

            modelBuilder.Entity<Aluno>()
            .HasOne(e => e.Turma)//1 aluno tem 1 turma
            .WithMany(e => e.Aluno)//1 turma tem varios alunos
            .HasForeignKey(e => e.Id_Turma);//campo da FK           


        }

    }
}
