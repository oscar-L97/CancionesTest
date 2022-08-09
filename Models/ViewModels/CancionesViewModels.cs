using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CancionesTest.Models.ViewModels
{
    public class CancionesViewModels
    {
        public int id { get; set; } 
        public string Titulo { get; set; }
        public string Grupo { get; set; }
        public string Año { get; set; }
        public string Genero { get; set; }
    }
}