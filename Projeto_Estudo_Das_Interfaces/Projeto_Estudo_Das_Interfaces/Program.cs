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
                #region Diferença ente IEnumerable x IQueryable

                //retorna todos os dados do banco de dados e fez o filtro na memoria
                //IEnumerable<Aluno> alunos = _context.Alunos;  

                //retorna somente os registros necessarios pois o filtro ja é feito no banco de dados
                IQueryable<Aluno> alunos = _context.Alunos;

                #endregion

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
