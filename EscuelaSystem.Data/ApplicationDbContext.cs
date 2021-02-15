using EscuelaSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Materia> Materia { get; set; }

        public DbSet<Alumnos> Alumnos { get; set; }

        public DbSet<Instructor> Instructor { get; set; }

    }
}
