using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CancionesTest.Models.ViewModels
{
    public class AgregarViewModel
    {
        [StringLength(100)]
        [Required]
        public string Titulo { get; set; }
        [StringLength(50)]
        [Required]
        public string Grupo { get; set; }
        [StringLength(50)]
        [Required]
        public string Año { get; set; }
        [StringLength(50)]
        [Required]
        public string Genero { get; set; }
    }
}