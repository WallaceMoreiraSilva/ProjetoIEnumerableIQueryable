using Projeto_Estudo_Das_Interfaces.Data;
using Projeto_Estudo_Das_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Estudo_Das_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new AppDbContext())
            {
                IEnumerable<Aluno> alunos = _context.Alunos;

                IEnumerable<Aluno> resultado = alunos.Where(a => a.Idade > 21).ToList();

                foreach (var aluno in resultado)
                {
                    Console.WriteLine($"{aluno.Nome} {aluno.Idade}");
                }
            }

            Console.ReadLine();
        }
    }
}
