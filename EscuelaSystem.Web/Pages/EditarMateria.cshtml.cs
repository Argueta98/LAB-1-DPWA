using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace EscuelaSystem.Web.Pages
{
    public class EditarMateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiaRepository;
        public EditarMateriaModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public Materia Materia { get; set; }
        public IActionResult OnGet(int id)
        {
            Materia = _materiaRepository.GetById(id);
            if(Materia == null)
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
            var materiaToUpdate = _materiaRepository.GetById(id);
            if (materiaToUpdate == null)
                return NotFound();

            materiaToUpdate.Codigo = Materia.Codigo;
            materiaToUpdate.Decripcion = Materia.Decripcion;
            materiaToUpdate.Habilitada = Materia.Habilitada;

            _materiaRepository.Update(materiaToUpdate);
            
            return RedirectToPage("./Materias");
        }
    }
}
