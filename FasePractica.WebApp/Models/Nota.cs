using System.ComponentModel.DataAnnotations;

namespace FasePractica.WebApp.Models
{
    public class Nota
    {
        public int NotaId { get; set; }
        public Estudiante Estudiante { get; set; }
        public Proyecto Proyecto { get; set; }
        [Display(Name = "Calificación")]
        public float Calificacion { get; set; }
        public bool Aprueba { get; set; }

    }
}
