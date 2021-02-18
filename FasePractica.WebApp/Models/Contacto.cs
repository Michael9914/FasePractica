using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FasePractica.WebApp.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        [Display(Name ="Teléfono")] 
        public string Telefono { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        [ForeignKey("Empresa")]
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}