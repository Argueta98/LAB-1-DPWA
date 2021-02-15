using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data.Repositories
{
   public class AlumnosRepository : Repository<Alumnos>, IAlumnosRepository
    {
        private readonly ApplicationDbContext _db;
        public AlumnosRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
