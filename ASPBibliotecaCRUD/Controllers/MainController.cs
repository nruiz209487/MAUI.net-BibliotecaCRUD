using BL_Biblioteca;
using ENT_Bibloteca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPBibliotecaCRUD.Controllers
{
    /// <summary>
    /// Homecontroller para cada pagina 
    /// </summary>
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            List<Genero> list;
            try
            {
                list = ClsListadosBL.ObtenerListadoGeneros();
                return View(list);
            }


            catch (Exception)
            {
                return View("Error");
            }
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            List<Libro> list;
            try
            {
                list = ClsListadosBL.ObtenerListadoDeLibrosPorGenero(id);
                return View(list);
            }

            catch (Exception)
            {
                return View("Error");
            }

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

                ClsListadosBL.AnyadirLibro(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            Libro obj;
            try
            {
                obj = ClsListadosBL.ObtenerLibro(id);
                return View(obj);
            }
            catch (Exception)
            {
                return View("Error");
            }

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
            catch (Exception)
            {
                return View("Error");
            }
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ClsListadosBL.EliminarLibro(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

    }
}
