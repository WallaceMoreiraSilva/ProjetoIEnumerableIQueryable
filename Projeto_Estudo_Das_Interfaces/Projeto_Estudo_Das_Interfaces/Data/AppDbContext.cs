using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projeto_Estudo_Das_Interfaces.Configuration;
using Projeto_Estudo_Das_Interfaces.Models;

namespace Projeto_Estudo_Das_Interfaces.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> option)
            : base(option) { }

        public DbSet<Aluno> Alunos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                //.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Biblioteca;");
                .UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Biblioteca;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
        }
    }
}
