using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto_Estudo_Das_Interfaces.Models;

namespace Projeto_Estudo_Das_Interfaces.Configuration
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.Property(s => s.Idade)
                .IsRequired(false);

            builder.HasData
            (
                new Aluno
                {
                    Id = 1,
                    Nome = "Maria",
                    Idade = 30
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "José",
                    Idade = 25
                },
                new Aluno
                {
                    Id = 3,
                    Nome = "Amanda",
                    Idade = 28
                },
                new Aluno
                {
                    Id = 4,
                    Nome = "Paulo",
                    Idade = 19
                },
                new Aluno
                {
                    Id = 5,
                    Nome = "Fernanda",
                    Idade = 20
                },
                new Aluno
                {
                    Id = 6,
                    Nome = "Camila",
                    Idade = 18
                },
                new Aluno
                {
                    Id = 7,
                    Nome = "Ana",
                    Idade = 21
                },
                new Aluno
                {
                    Id = 8,
                    Nome = "Germano",
                    Idade = 23
                },
                new Aluno
                {
                    Id = 9,
                    Nome = "Selma",
                    Idade = 17
                },
                new Aluno
                {
                    Id = 10,
                    Nome = "Vitor",
                    Idade = 22
                }
            );
        }
    }
}
