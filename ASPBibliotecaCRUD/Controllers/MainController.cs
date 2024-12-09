using BL_Biblioteca;
using ENT_Bibloteca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPBibliotecaCRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            List<Genero> list = ClsListadosBL.ObtenerListadoGeneros();
            return View(list);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            List<Libro> list = ClsListadosBL.ObtenerListadoDeLibrosPorGenero(id);
            return View(list);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Libro obj)
        {
            try
            {
                ClsListadosBL.AnyadirLibro(obj.Titulo, obj.Sinopsis, obj.Titulo, obj.fechaDeSalida, obj.IdGenero, obj.Img);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            Libro obj = ClsListadosBL.ObtenerLibro(id);
            return View(obj);
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Libro obj)
        {
            try
            {
                ClsListadosBL.ModificarLibro(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            Libro obj = ClsListadosBL.ObtenerLibro(id);
            return View(obj);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Libro obj)
        {
            try
            {
                ClsListadosBL.EliminarLibro(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
