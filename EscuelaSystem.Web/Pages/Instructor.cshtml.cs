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
    public class InstructorModel : PageModel
    {
        private IInstructorRepository _instructorRepository;

        public InstructorModel(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        [BindProperty]
        public IEnumerable<Instructor>  Instructor { get; set; }

        public IActionResult OnGet()
        {
            Instructor = _instructorRepository.List();
            return Page();
        }
    }
}
