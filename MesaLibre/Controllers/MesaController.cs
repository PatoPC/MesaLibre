using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class MesaController : Controller
    {
        // GET: Mesas
        public ActionResult CrearMesa()
        {
            return View();
        }
        public ActionResult _ListaMesas()
        {
            return View();
        }

        #region BuscarMesas
        public ActionResult BuscarMesa()
        {
            return View();
        }
        public ActionResult BuscarMesaTodos()
        {
            return View("_ListaMesas");
        }
        public ActionResult buscarMesasPorRestaurante()
        {
            return View("_ListaMesas");
        }
        #endregion BuscarMesas
    }//class
}