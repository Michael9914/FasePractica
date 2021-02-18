using System.ComponentModel.DataAnnotations;

namespace FasePractica.WebApp.Models
{
    public class Estudiante : Persona
    {
        public int EstudianteId { get; set; }
        [Display(Name = "CódigoIgnug")]
        public string CodigoIgnug { get; set; }
    }
}
