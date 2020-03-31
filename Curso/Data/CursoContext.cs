using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Curso.Models;

namespace Curso.Data
{
    public class CursoContext : DbContext
    {
        public CursoContext (DbContextOptions<CursoContext> options)
            : base(options)
        {
        }

        public DbSet<Curso.Models.Departament> Departament { get; set; }
    }
}
