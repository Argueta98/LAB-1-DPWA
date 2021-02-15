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
    public class EliminarMateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiasRepository;
        public EliminarMateriaModel(IMateriaRepository materiasRepository)
        {
            _materiasRepository = materiasRepository;
        }
        [BindProperty]
        public Materia Materias { get; set; }
        public IActionResult OnGet(int id)
        {
            Materias = _materiasRepository.GetById(id);
            if (Materias == null)
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

            var materiasToDelete = _materiasRepository.GetById(id);
            if (materiasToDelete == null)
                return NotFound();
            materiasToDelete.Codigo = Materias.Codigo;
            materiasToDelete.Decripcion = Materias.Decripcion;
            materiasToDelete.Habilitada = Materias.Habilitada;

            _materiasRepository.Delete(materiasToDelete);

            return RedirectToPage("./Materias");
        }
    }
}
