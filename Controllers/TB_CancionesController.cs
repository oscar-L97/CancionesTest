using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CancionesTest.Models;
using CancionesTest.Models.ViewModels;

namespace CancionesTest.Controllers
{
    public class TB_CancionesController : Controller
    {
        // GET: TB_Canciones
        public ActionResult Index()
        {
           List<CancionesViewModels> list;
            using(CancionesDBEntities db = new CancionesDBEntities())
            {
                 list = (from t in db.TB_Canciones
                            select new CancionesViewModels
                            {
                                id = t.ID,
                                Titulo = t.Titulo,
                                Grupo = t.Grupo,
                                Año = t.Año,
                                Genero = t.Genero
                            }).ToList();
            }

            return View(list);
        }
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(AgregarViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CancionesDBEntities db = new CancionesDBEntities())
                    {
                        var Tabla = new TB_Canciones();
                        Tabla.Titulo = model.Titulo;
                        Tabla.Grupo = model.Grupo;
                        Tabla.Año = model.Año;
                        Tabla.Genero = model.Genero;

                        db.TB_Canciones.Add(Tabla);
                        db.SaveChanges();
                    }
                    return Redirect("/");
                }
                return View(model);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            using(CancionesDBEntities db = new CancionesDBEntities())
            {
                var row = db.TB_Canciones.Find(id);
                db.TB_Canciones.Remove(row);
                db.SaveChanges();
            }
            return Redirect("/");
        }
    }
}