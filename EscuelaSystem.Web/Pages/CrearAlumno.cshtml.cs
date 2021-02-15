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
    public class CrearAlumnoModel : PageModel
    {
        private readonly IAlumnosRepository _alumnosRepository;
        public CrearAlumnoModel(IAlumnosRepository alumnosRepository)
        {
            _alumnosRepository = alumnosRepository;
        }
        [BindProperty]
        public Alumnos Alumnos { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _alumnosRepository.Insert(Alumnos);

            return RedirectToPage("./Alumnos");
        }
    }
}
