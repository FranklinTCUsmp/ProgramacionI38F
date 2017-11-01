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

            return View(eventos);
        }

        public ActionResult Ver(int id)
        {
            var modelo = new EventosModel();

            var evento = modelo.GetEventoPorId(id);

            return View(evento);
        }

        public ActionResult Promociones()
        {
            return View();
        }
    }
}