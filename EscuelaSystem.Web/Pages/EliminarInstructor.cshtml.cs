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
    public class EliminarInstructorModel : PageModel
    {
        private readonly IInstructorRepository _instructorRepository;

        public EliminarInstructorModel(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public Instructor Instructor { get; set; }

        public IActionResult OnGet(int id)
        {
            Instructor = _instructorRepository.GetById(id);
            if (Instructor == null)
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

            var instructorToDelete = _instructorRepository.GetById(id);
            if (instructorToDelete == null)
                return NotFound();
            instructorToDelete.Codigo = Instructor.Codigo;
            instructorToDelete.Nombres = Instructor.Nombres;
            instructorToDelete.Apellidos = Instructor.Apellidos;
            instructorToDelete.Edad = Instructor.Edad;
            instructorToDelete.Activo = Instructor.Activo;

            _instructorRepository.Delete(instructorToDelete);

            return RedirectToPage("./Instructor");
        }

    }
}
