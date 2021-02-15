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
    public class EditarAlumnoModel : PageModel
    {
        private readonly IAlumnosRepository _alumnosRepository;

        public EditarAlumnoModel(IAlumnosRepository alumnosRepository)
        {
            _alumnosRepository = alumnosRepository;
        }

        [BindProperty]
        public Alumnos Alumnos { get; set; }
        public IActionResult OnGet(int id)
        {
            Alumnos = _alumnosRepository.GetById(id);
            if (Alumnos == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var alumnosToUpdate = _alumnosRepository.GetById(id);
            if (alumnosToUpdate == null)
                return NotFound();

            alumnosToUpdate.Codigo = Alumnos.Codigo;
            alumnosToUpdate.Nombres = Alumnos.Nombres;
            alumnosToUpdate.Apellidos = Alumnos.Apellidos;
            alumnosToUpdate.Edad = Alumnos.Edad;
            alumnosToUpdate.Activo = Alumnos.Activo;

            _alumnosRepository.Update(alumnosToUpdate);

            return RedirectToPage("./Alumnos");
        }
    }
}
