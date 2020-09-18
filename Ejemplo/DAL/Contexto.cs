using Ejemplo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Estudiantes> Estudiantes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging().UseSqlite(@"Data Source= Estudiantes");
        }
    }
}