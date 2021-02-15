using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class AlumnosModel : PageModel
    {
        private IAlumnosRepository _alumnosRepository;

        public AlumnosModel(IAlumnosRepository alumnosRepository)
        {
            _alumnosRepository = alumnosRepository;
        }

        [BindProperty]
        public IEnumerable<Alumnos> Alumnos{ get; set; }
        public IActionResult OnGet()
        {
            Alumnos = _alumnosRepository.List();
            return Page();
        }
    }
}
