using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class TipoMenuController : Controller
    {
        // GET: TipoMenu
        public ActionResult CrearTipoMenu()
        {
            return View();
        }

        public ActionResult _ListaTipoMenu()
        {
            return View();
        }
    }
}