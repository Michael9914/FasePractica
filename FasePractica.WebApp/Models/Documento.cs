using System;
using System.ComponentModel.DataAnnotations;

namespace FasePractica.WebApp.Models
{
    public class Documento
    {
        public int DocumentoId { get; set; }
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        public DateTime FirmadoEl { get; set; }
        public string AlmacenadoEn { get; set; }
        public Estado Estado { get; set; }
    }
}
