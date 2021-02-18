using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FasePractica.WebApp.Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }
        public List<Nota> Notas { get; set; }
        public Empresa Empresa { get; set; }
        public Semestre Semestre { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Tecnología")]
        public string Tecnologia { get; set; }
        [Display(Name = "TutorAcadémico")]
        public Tutor TutorAcademico { get; set; }
        public Contacto TutorEmpresarial { get; set; }
    }
}
