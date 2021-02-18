using System.ComponentModel.DataAnnotations;

namespace FasePractica.WebApp.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }
        public string CorreoInstitucional { get; set; }
        public string CorreoPersonal { get; set; }
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
    }
}
