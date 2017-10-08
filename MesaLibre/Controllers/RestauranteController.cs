using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class RestauranteController : Controller
    {
        // GET: Restaurente
        public ActionResult CrearRestaurante()
        {
            return View();
        }




        #region Busqueda Restaurante
        public ActionResult BuscarRestaurante()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarRestaurantePorRUC()
        {
            return View("_ListaRestaurantes", "");
        }

        [HttpPost]
        public ActionResult buscarRestaurantePorNombreComercial()
        {
            return View("_ListaRestaurantes", "");
        }

        [HttpPost]
        public ActionResult buscarRestaurantePorFechaCreacion()
        {
            return View("_ListaRestaurantes", "");
        }

        #endregion Busqueda Reservas
    }
}