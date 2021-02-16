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
    public class CrearInstructorModel : PageModel
    {
        private readonly IInstructorRepository _instructorRepository;
        public CrearInstructorModel(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        [BindProperty]
        public Instructor   Instructor { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _instructorRepository.Insert(Instructor);

            return RedirectToPage("./Instructor");
        }
    }
}
