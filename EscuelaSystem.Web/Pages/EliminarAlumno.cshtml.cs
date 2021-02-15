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
    public class EliminarAlumnoModel : PageModel
    {
        private readonly IAlumnosRepository _alumnosRepository;

        public EliminarAlumnoModel(IAlumnosRepository alumnosRepository)
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
            //if (ModelState.)
            //{
            //    return RedirectToPage("./Materias");
            //}

            var alumnosToDelete = _alumnosRepository.GetById(id);
            if (alumnosToDelete == null)
                return NotFound();
            alumnosToDelete.Codigo = Alumnos.Codigo;
            alumnosToDelete.Nombres = Alumnos.Nombres;
            alumnosToDelete.Apellidos = Alumnos.Apellidos;
            alumnosToDelete.Edad = Alumnos.Edad;
            alumnosToDelete.Activo = Alumnos.Activo;

            _alumnosRepository.Delete(alumnosToDelete);

            return RedirectToPage("./Alumnos");
        }
    }
}
