using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class LocalController : Controller
    {
        // GET: Local
        public ActionResult CrearLocal()
        {
            return View();
        }


#region BuscarLocales
        public ActionResult BuscarLocal()
        {
            return View();
        }

        public ActionResult BuscarLocalesTodos()
        {
            return View("_ListaLocales");
        }

        public ActionResult buscarLocalPorRestaurante()
        {
            return View("_ListaLocales");
        }
    }
#endregion BuscarLocales
}