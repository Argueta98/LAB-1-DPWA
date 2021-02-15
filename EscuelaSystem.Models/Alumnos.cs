using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.Models
{
     public class Alumnos : EntityBase
    {
        [Required(ErrorMessage = "El campo Codigo de alumno no puede estar vacio")]
        [MinLength(2, ErrorMessage = "Escriba mas de 2 o mas digitos ")]
        [MaxLength(10, ErrorMessage = "Escriba menos de 10 digitos ")]
        [Display(Name = "Codigo de Materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo nombre de alumno no debe quedar vacio")]
        [MinLength(2, ErrorMessage = "Escriba 3 o más caracteres ")]
        [MaxLength(50, ErrorMessage = "Escriba menos de 50 digitos ")]
        [Display(Name = "Nombre del Alumno")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo nombre de alumno no debe quedar vacio")]
        [MinLength(2, ErrorMessage = "Escriba 3 o más caracteres ")]
        [MaxLength(50, ErrorMessage = "Escriba menos de 50 digitos ")]
        [Display(Name = "Apellido del Alumno")]
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        [Required(ErrorMessage = "El campo nombre de alumno no debe quedar vacio")]
        [MinLength(1, ErrorMessage = "Escriba 1 o 2 caracteres")]
        [MaxLength(2, ErrorMessage = "Escriba 2 caracteres ")]
        public bool Activo { get; set; }
    }
}
