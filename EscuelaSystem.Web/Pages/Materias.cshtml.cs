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
    public class MateriasModel : PageModel
    {
        private IMateriaRepository _materiaRepository;

        public MateriasModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public IEnumerable<Materia> Materias { get; set; }

        public IActionResult OnGet()
        {
            Materias = _materiaRepository.List();
            return Page();
        }
    }
}
