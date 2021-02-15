using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.Models
{
    public class Materia: EntityBase
    {   
        [Required(ErrorMessage = "El campo Codigo de materia no puede estar vacio")]
        [MinLength(2,ErrorMessage="Escriba mas de 2 o mas digitos ")]
        [MaxLength(10, ErrorMessage = "Escriba menos de 10 digitos ")]
        [Display(Name = "Codigo de Materia")]
        public string Codigo { get; set; }
        [Required (ErrorMessage = "El campo nombre de materia no puede estar vacio")]
        [MinLength(3, ErrorMessage = "Escriba mas de 3 o mas digitos ")]
        [MaxLength(25, ErrorMessage = "Escriba menos de 25 digitos ")]
        [Display(Name = "Nombre de Materia")]
        public string Decripcion { get; set; }
        public bool Habilitada { get; set; }
    }
}
