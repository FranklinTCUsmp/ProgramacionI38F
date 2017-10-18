using EventosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventosApp.Controllers
{
    public class EventosController : Controller
    {
        public ActionResult Listado()
        {
            var modelo = new EventosModel();
            var eventos = modelo.ListadoEventos();

            ViewBag.ListadoEventos = eventos;


            return View();
        }

        public ActionResult Promociones()
        {
            return View();
        }
    }
}