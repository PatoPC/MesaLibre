using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
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
            return View("_ListaReservas", "");
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

        [HttpPost]
        public ActionResult CrearReservaManual(string TipoMenu)
        {
            TempData["mensajeExitoso"] = "Registro Guardado correctamente";
            return View("BuscarReservas");
        }
        #endregion Crear Reservas 
    }//class
}