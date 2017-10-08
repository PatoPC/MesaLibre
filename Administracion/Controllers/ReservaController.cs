using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion.Controllers
{
    public class ReservaController : Controller
    {
        #region Busqueda Reservas
        public ActionResult BuscarReservas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarReservasPorReferencia()
        {
            return View("_ListaReservas","");
        }

        [HttpPost]
        public ActionResult buscarReservasPorIdentificacionCliente()
        {
            return View("_ListaReservas", "");
        }

        [HttpPost]
        public ActionResult buscarReservasPorFechaCreacion()
        {
            return View("_ListaReservas", "");
        }

        #endregion Busqueda Reservas

        #region Crear Reservas
        public ActionResult CrearReservaManual()
        {
            return View();
        }
        #endregion Crear Reservas 
    }//class
}