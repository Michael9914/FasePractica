using System.ComponentModel.DataAnnotations;

namespace FasePractica.WebApp.Models
{
    public class Tutor : Persona
    {
        public int TutorId { get; set; }
        [Display(Name = "CódigoIgnug")]
        public string CodigoIgnug { get; set; }
    }
}
