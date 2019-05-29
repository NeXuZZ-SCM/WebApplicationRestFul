using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationRestFul.Controllers
{
    public class ModeloPersonaController : Controller
    {
        // GET: ModeloPersona
        public /*ActionResult*/ string Index()
        {
            List<Models.ModeloPersona> listado = new List<Models.ModeloPersona>();
            Models.ModeloPersona personas = new Models.ModeloPersona { id = 1, nombre = "Raul", apellido = "Gomez" };
            listado.Add(personas);
            personas = new Models.ModeloPersona { id = 2, nombre = "Juan", apellido = "Gutierres" };
            listado.Add(personas);
            personas = new Models.ModeloPersona { id = 3, nombre = "Pedro", apellido = "Martinez" };
            listado.Add(personas);
            personas = new Models.ModeloPersona { id = 4, nombre = "Federico", apellido = "Rovosky" };
            listado.Add(personas);
            personas = new Models.ModeloPersona { id = 5, nombre = "Rodrigo", apellido = "Alfero" };
            listado.Add(personas);

            string output = JsonConvert.SerializeObject(listado);

            return output;
            //return View();
        }

        //// GET: ModeloPersona/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ModeloPersona/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ModeloPersona/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ModeloPersona/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ModeloPersona/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ModeloPersona/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ModeloPersona/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
