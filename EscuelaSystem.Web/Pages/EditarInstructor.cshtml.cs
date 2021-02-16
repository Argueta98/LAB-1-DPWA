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
    public class EditarInstructorModel : PageModel
    {
        private readonly IInstructorRepository _instructorRepository;
        public EditarInstructorModel(IInstructorRepository materiaRepository)
        {
            _instructorRepository = materiaRepository;
        }

        [BindProperty]
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var instructorToUpdate = _instructorRepository.GetById(id);
            if (instructorToUpdate == null)
                return NotFound();

            instructorToUpdate.Codigo = Instructor.Codigo;
            instructorToUpdate.Nombres = Instructor.Nombres;
            instructorToUpdate.Apellidos = Instructor.Apellidos;
            instructorToUpdate.Edad = Instructor.Edad;
            instructorToUpdate.Activo = Instructor.Activo;
            

            _instructorRepository.Update(instructorToUpdate);

            return RedirectToPage("./Instructor");
        }
    }
}
